import pandas as pd
import numpy as np

moni_dl = []


def processMoni(senser_data):
    sens0 = senser_data[0].replace("{{", "")
    sens1 = sens0.replace("}}", "")
    sens2 = sens1.split(",")
    sen_d = (float(sens2[0]) + float(sens2[1])) / 2
    return sen_d


def printDFF(dff, n, dist, outpath):
    for k in range(0, n - 1):
        df0 = dff.loc[[k]]
        axleW0 = df0['Axles'].str.split(" ", expand=True)  # axle weight
        axleD0 = df0['A2A'].str.split(" ", expand=True)  # axle distance

        for j in range(0, axleW0.shape[1]):
            pz = float(axleW0.loc[:, [j]].values[0][0]) * 9.96402  # ton to kN
            dxx = 27.04 * 0.25 + dist
            if j == 0:
                dx = dxx
            else:
                dx -= float(axleD0.loc[:, [j - 1]].values[0][0])

            print(dx,'II')

            with open(outpath, 'a') as file:
                file.write(
                    "STEL 1001 1032 1 TYP PZZ" +
                    " a " + str(dx) +
                    " P " + str(pz) +
                    " ey " + str(1) + "[m]\n" +
                    "STEL 1001 1032 1 TYP PZZ" +
                    " a " + str(dx) +
                    " P " + str(pz) +
                    " ey " + str(-1) + "[m]\n"
                )


def printDF(df,i,outpath):
    # Monitored Deflection
    sens1 = df['ch203'].values
    sens2 = df['ch204'].values
    moniD = (processMoni(sens1) + processMoni(sens2)) / 2
    lf = 1001 + i
    moni_dl.append([lf, moniD])

    # load mapping
    axleW = df['Axles'].str.split(" ", expand=True)  # axle weight
    axleD = df['A2A'].str.split(" ", expand=True)  # axle distance
    autoL = df['Length'].values[0]

    with open(outpath, 'a') as file:
        file.write(
            "LF " + str(1001 + i) + "\n"
        )

    for j in range(0, axleW.shape[1]):
        pz = float(axleW.loc[:, [j]].values[0][0]) * 9.96402  # ton to kN
        dxx = 27.04 * 0.25 + autoL
        if j == 0:
            dx = dxx
        else:
            dx -= float(axleD.loc[:, [j - 1]].values[0][0])

        print(dx, 'I')

        # if dx < br_len: # estimate the loads not located on bridge
        with open(outpath, 'a') as file:
            file.write(
                "STEL 1001 1032 1 TYP PZZ" +
                " a " + str(dx) +
                " P " + str(pz) +
                " ey " + str(1) + "[m]\n" +
                "STEL 1001 1032 1 TYP PZZ" +
                " a " + str(dx) +
                " P " + str(pz) +
                " ey " + str(-1) + "[m]\n"
            )


def conventor(psppath):
    data = pd.read_csv(psppath, ";")

    num_lc = 10
    outpath = 'C:/Users/flin/PycharmProjects/wisib/SOFI/load.dat'

    # max. distance
    br_len = 27.04*0.75 # 20.28m

    ID_List = data['ID'].values
    Dis_List = data['Distance'].values
    Len_List = data['Length'].values


    with open(outpath, 'w') as file:
        file.write(
            "#define project=esslingen\n"
            "#define cdb=esslingen.cdb\n"
            "!#!Chapter Massensimulation\n"
            "+prog sofiload\n"
            "kopf Traffic-Load\n"
        )

    for i in range(0, num_lc):

        try:
            del dff
        except:
            pass

        dist = Dis_List[i] + Len_List[i]
        id = ID_List[i]
        print(id, "---", dist)

        j = i
        while dist < br_len:
            ie = j
            j -= 1
            dist = Dis_List[j:ie + 1].sum()
            id = ID_List[j:ie + 1]

        print(id, "///",dist)

        try:
            df = data.loc[data['ID']==id]
        except:
            n = np.size(id)
            df = data.loc[data['ID'] == id[n-1]]
            dff = data.loc[0:n-2]

        # ----------------
        # df processing
        # ----------------

        printDF(df, i, outpath)

        try:
            printDFF(dff,n,dist,outpath)
        except:
            pass

        print("\n")


        with open(outpath, 'a') as file:
            file.write("\n")

    with open(outpath, 'a') as file:
        file.write("ENDE\n\n" +
                   "+prog ase\n" +
                   "loop#1 " + str(num_lc) + "\n"
                   "SFIX 3 plf 3\n" +
                   "LF 2001+#1 fakg 1\n" +
                   " LC 1001+#1\n" +
                   "ENDE\n" + "ENDLOOP\n" + "ENDE\n")

    df = pd.DataFrame(moni_dl, columns=['Load_Case', 'Monitored_Value'])
    df.to_csv('C:/Users/flin/PycharmProjects/wisib/csv_Bank/benchmark.csv')

    return outpath

if __name__ == '__main__':
    # psp_path = "C:/Users/flin/PycharmProjects/wisib/csv_Bank/VOG2.csv"
    psp_path = "C:/Users/flin/PycharmProjects/wisib/csv_Bank/TestTRA.csv"
    loadpath = conventor(psp_path)


