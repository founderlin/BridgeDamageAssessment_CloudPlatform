import pandas as pd
import math
import os
import numpy as np
os.environ["PATH"] += os.pathsep + 'C:/Program Files (x86)/Graphviz2.38/bin'
from graphviz import Source



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

def identification(df0, df1, dot_path, d):
    listN = np.arange(1, len(df1)+1)
    count1 = 0
    dotpath = dot_path

    with open(dotpath, 'w') as f:
        f.write('digraph Tree {\r')
        f.write('node [shape=box, style="filled", color="black", fontname=helvetica] ;\r')
        f.write('edge [fontname=helvetica] ;\r')

    for i in range(0, len(df1.T)):
        list1 = []
        list0 = []
        listV = df1.iloc[:, i].values
        bemark = df0.values[i][2]
        max = bemark*(1+d)
        min = bemark*(1-d)
        # print(bemark)
        # print('listV', listV)

        # print('listN', listN)

        for j in listN:
            m = j - 1
            # max = bemark[m]
            # print('m=', m)
            if min <= listV[m]*-1 <= max:
                # print('item in listN', m)
                list1.append(j)
                count1 += 1
            else:
                # print('item in listN', m)
                list0.append(j)

        num = len(listN)
        listN = list1

        count0 = num - count1
        sample = num

        print(count1, count0, num)
        if num == 0:
            continue
        elif count1 == 0:
            entropy = 'N/A'
        elif count0 == 0:
            entropy = - (count1 / num) * math.log2(count1 / num)
            entropy = format(entropy, '.3f')
        else:
            entropy = - (count0 / num) * math.log2(count0 / num) \
                      - (count1 / num) * math.log2(count1 / num)
            entropy = format(entropy, '.3f')

        # print(count1, count0, entropy)
        # print(list1)
        # print(list0)
        # print('================')
        with open(dotpath, 'a') as f:
            f.write(str(10 * i + 1) + '[label=<entropy = ' + str(entropy) +
                    '<br/>samples =' + str(sample) +
                    '<br/>value = [' + str(count1) + ',' + str(count0) + ']>, fillcolor="#399de5"];\r')

        # print(10 * i + 1, '[label=<entropy = ', entropy,
        #       '<br/>samples =', sample,
        #       '<br/>value = [', count1, ',', count0, ']>, fillcolor="#399de5"];')
        if i != 0:
            with open(dotpath, 'a') as f:
                f.write(str(10 * i + 2) + '[label=<samples =' + str(count0_p) + '>, fillcolor="#e58139"];\r')
                f.write(str(10 * (i - 1) + 1) + '->' + str(10 * i + 1) + ' ;\r')
                f.write(str(10 * (i - 1) + 1) + '->' + str(10 * i + 2) + ' ;\r')

            # print(10 * i + 2, '[label=<samples =', count0, '>, fillcolor="#e58139"];')
            # print(10 * (i - 1) + 1, '->', 10 * i + 1, ' ;')
            # print(10 * (i - 1) + 1, '->', 10 * i + 2, ' ;')
        count1_p = count1
        count0_p = count0
        count1 = 0

    with open(dotpath, 'a') as f:
        f.write('}')
    # print('}')

def plotTree(dot_path):
    s = Source.from_file(dot_path)
    s.view()

if __name__ == '__main__':
    num_mv = 11
    benchmark = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/benchmark.csv'
    dot_path = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/tree.dot'
    df0, df1 = importData(benchmark, num_mv)
    d = 0.5
    identification(df0, df1, dot_path, d)
    plotTree(dot_path)