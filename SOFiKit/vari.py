from SOFiKit.beam import *
import csv

def parameter(csvpath, beam_sti):
    # with open(csvpath, 'r') as f:
    #     reader = csv.reader(f)
    #     data0 = []
    #     for row in reader:
    #         data0.append(row[0:])
    # data2 = data0

    with open(csvpath, 'r') as f:
        reader = csv.reader(f)
        data0 = []
        for row in reader:
            data0.append(row[1:])
    data1 = data0[1:]
    data2 = []
    for i in data1:
        # ii = i
        # for j in ii:
        #     print(j)
        ii = [ k for k in i for j in range(2)]
        # print(ii)
        data2.append(ii)

    list_len = []
    list_elem = data0[1]
    df_bmsti = pd.read_csv(beam_sti, ',')
    for i in list_elem:
        id = df_bmsti[df_bmsti['Beam_Nr'] == int(i)].index[0]
        len = df_bmsti['Beam_Len'].iloc[id]
        list_len.append(0)
        list_len.append(len)

    data2.insert(1, list_len)
    # print(data2)
    return data2


def Variation(inpath1, inpath2, csvpath, beam_sti, indicator):

    data = parameter(csvpath, beam_sti)

    beam_nr_list = [int(i) for i in data[0]]
    beam_x_list = [float(i) for i in data[1]]
    eiy_LISTs = data[2::1]
    print(beam_nr_list)
    print(beam_x_list)
    print(eiy_LISTs)

    ii = 0

    # for i in range(0,len(eiy_LISTs)):
    while ii < len(eiy_LISTs):
        ni = ii + 25*indicator
        # var_.cdb
        outpath1 = "C:/Users/flin/PycharmProjects/wisib/WareHouse/var_"+str(ni + 1)+".cdb"
        dll, index = concDLL(inpath1, outpath1)
        flist = setMethode(dll)
        # --- set beam stiffness ---
        eiy_list = [float(j) for j in eiy_LISTs[ii]]
        print(eiy_list)
        setBeamSTI(index, flist, beam_nr_list , beam_x_list, eiy=eiy_list)
        # closeDB(dll)

        # sim_.dat
        with open(inpath2, 'r') as f:
            file = f.readlines()
        # idfer = '#define'
        # idlist = []

        file[1] = '#define project=var_' + str(ni + 1) + '\n'
        file[2] = '#define cdb=var_' + str(ni + 1) + '.cdb\n'

        outpath2 = "C:/Users/flin/PycharmProjects/wisib/WareHouse/sim_" + str(ni + 1) + ".dat"
        with open(outpath2, 'w') as f:
            for i in file:
                f.writelines(i)
        ii += 1

if __name__ == '__main__':
    cdbpath = "C:/Users/flin/PycharmProjects/wisib/SOFI/esslingen.cdb"
    datpath = "C:/Users/flin/PycharmProjects/wisib/SOFI/load.dat"
    # csvpath = "C:/Users/flin/PycharmProjects/wisib/csv_Bank/parameter.csv"
    beam_sti = 'C:\\Users\\flin\\PycharmProjects\\wisib\\csv_Bank\\beam_sti.csv'
    i = 1 # 0 or 1
    csvpath = "C:/Users/flin/PycharmProjects/wisib/csv_Bank/para3"+str(i)+".csv"
    Variation(cdbpath, datpath, csvpath, beam_sti, i)
