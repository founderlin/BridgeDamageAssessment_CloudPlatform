import itertools
import pandas as pd

para1005 = [0.01, 0.1, 0.2, 0.3, 0.4]
para1008 = [0.01, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9]

df1 = pd.DataFrame([int(1005), int(1008)]).T
df2 = pd.DataFrame(itertools.product(para1005, para1008))

df3 = df1.append(df2, ignore_index=True)
df3.to_csv("csv_Bank/para3.csv")

# print(df3)

for i in range(0,2):
    df3 = df1.append(df2.iloc[25*i:25*(i+1),:], ignore_index=True)
    df3.to_csv("csv_Bank/para3"+str(i)+".csv")

    print(df3)