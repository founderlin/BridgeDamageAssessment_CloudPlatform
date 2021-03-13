from SOFiKit import plot_sub

import pandas as pd
import numpy as np

def importData(benchmark, num_mv):
    # import monitoring data
    df0 = pd.read_csv(benchmark)
    # print(df0)

    # import simulation results
    data = []
    for i in range(1, int(num_mv + 1)):
        inpath = "C:/Users/flin/PycharmProjects/wisib/" \
                  "csv_Bank/deflection/var_" + str(i) + ".csv"
        list = pd.read_csv(inpath).values.tolist()
        data.append(list[0][1:])
    df1 = pd.DataFrame(data)
    # print(df1)

    return df0, df1

def identification(benchmark, deflections, df0, df1, d, num_mv):
    dec = np.zeros(shape=(len(df1), len(df1.T)))
    # print(len(df1.T))
    ident = []
    mv_cnt = []
    for i in range(0, len(df1.T)): #17
        listV = df1.iloc[:, i].values
        bemark = df0.values[i][2]
        max = bemark*(1+d)
        min = bemark*(1-d)

        for j in range(0, len(df1)): #11
            if min <= listV[j]*-1 <= max:
                dec[j,i] = dec[j,i] + 1

    df2 = pd.DataFrame(dec)
    # print(df2)
    # print(df2.values[0,:].sum(axis=0))
    for k in range(0, num_mv):
        ident.append(int(df2.values[k,:].sum(axis=0)))
        mv_cnt.append(int(k+1))
        # print(ident)

    stsc = pd.DataFrame([ident]).values.tolist()[0]
    # print(stsc)
    plot_sub.plotData(benchmark, deflections, stsc, d, num_mv)

if __name__ == '__main__':
    num_mv = 50
    benchmark = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/benchmark.csv'
    deflections = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/deflection/'
    # dot_path = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/tree.dot'
    df0, df1 = importData(benchmark, num_mv)
    d = 0.3
    identification(benchmark, deflections, df0, df1, d, num_mv)