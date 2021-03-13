import plotly
import plotly.graph_objects as go
import pandas as pd

df_n = pd.read_csv('C:/Users/flin/PycharmProjects/wisib/csv_Bank/quad_node_2d.csv', delimiter=',')
df_c = pd.read_csv('C:/Users/flin/PycharmProjects/wisib/csv_Bank/node_coor_2d.csv', delimiter=',')

x_c = []
y_c = []
z_c = []
data = []

for j in range(0, 4366):
    for i in range(1, 5):
        node_nr = df_n.iloc[j][i]
        try:
            node_coor = df_c.loc[df_c['Node_Nr'] == node_nr].values[0][1:4]
            x_c.append(node_coor[0])
            y_c.append(node_coor[1])
            z_c.append(node_coor[2])

        except:
            x_c.append(0)
            y_c.append(0)
            z_c.append(0)

    data_e = go.Mesh3d(
            x=x_c,
            y=y_c,
            z=z_c,
            color='lightblue', opacity=0.8
        )
    data.append(data_e)

fig = go.Figure(data=data)

plotly.offline.plot(fig, filename="2dplot.html", auto_open=True)