from SOFiKit import plot_sub

import pandas as pd
import numpy as np

def importData(benchmark, num_mv):
    # import monitoring data
    df0 = pd.read_csv(benchmark)
    print(df0)

    # import simulation results
    data = []
    for i in range(1, int(num_mv + 1)):
        inpath = "C:/Users/flin/PycharmProjects/wisib/" \
                  "csv_Bank/deflection/var_" + str(i) + ".csv"
        list = pd.read_csv(inpath).values.tolist()
        data.append(list[0][1:])
    df1 = pd.DataFrame(data)
    print(df1)

    return df0, df1

def bestfit(benchmark, deflections, df0, df1, num_mv):
    fit = np.zeros(shape=(len(df1), 2))

    moni = df0.iloc[:, 2].T.values
    for i in range(0, len(df1)): #50
        model =abs(df1.iloc[i, :].values)

        d = 0
        for sim, real in zip(model, moni):
            d = d + (sim-real)**2

        fit[i, 0] = i
        fit[i, 1] = (d**0.5)/1000

    print(fit[np.argsort(fit[:,1])])

if __name__ == '__main__':
    num_mv = 50
    benchmark = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/benchmark2.csv'
    deflections = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/deflection/'
    df0, df1 = importData(benchmark, num_mv)
    bestfit(benchmark, deflections, df0, df1, num_mv)