import plotly
import plotly.graph_objs as go
import pandas as pd
import numpy as np
np.set_printoptions(suppress=True)


def _plot3d(df_ndcoor, list_coor):

    scatter = dict(
        mode = "lines+markers",
        type = "scatter3d",
        x = df_ndcoor['Coor_X'][0:30],
        y = df_ndcoor['Coor_Y'],
        z = df_ndcoor['Coor_Z'],
        line = dict(width=5
        ),
        marker = dict(symbol='circle',
                      size=5,
                      color="rgb(255, 255, 128)",
                      line=dict(
                          color='rgb(140, 140, 170)',
                          width=2)
                     ))
    data = [ scatter ]

    for i in range(0, len(list_coor)):
        df_ndcoor_d = list_coor[i]
        scatter_d = dict(
            mode="lines+markers",
            type="scatter3d",
            x=df_ndcoor_d['Coor_X'],
            y=df_ndcoor_d['Coor_Y'],
            z=df_ndcoor_d['Coor_Z'],
            line=dict(width=5
                      ),
            marker=dict(symbol='circle',
                        size=5,
                        color="rgb(255, 0, 128)",
                        line=dict(
                            color='rgb(140, 140, 170)',
                            width=2)
                        ))
        data.append(scatter_d)

    layout = go.Layout(
            margin=go.layout.Margin(l=0, r=0, b=0, t=0, pad=4),
            scene = dict(
                xaxis=dict(
                    gridcolor='rgb(255, 255, 255)',
                    zerolinecolor='rgb(255, 255, 255)',
                    showbackground=True,
                    backgroundcolor='rgb(230, 230,230)',
                    title='x',
                    nticks=10,
                    range = [-50,50],
                    ),
                yaxis=dict(
                    gridcolor='rgb(255, 255, 255)',
                    zerolinecolor='rgb(255, 255, 255)',
                    showbackground=True,
                    backgroundcolor='rgb(230, 230,230)',
                    title='y',
                    nticks=10,
                    range = [-50,50],
                ),
                zaxis=dict(
                    gridcolor='rgb(255, 255, 255)',
                    zerolinecolor='rgb(255, 255, 255)',
                    showbackground=True,
                    backgroundcolor='rgb(230, 230,230)',
                    title='z',
                    nticks=10,
                    range = [-50,50],
                ),
            camera = dict(
                eye = dict(
                  x = 0.3,
                  y = 0.2,
                  z = 0.1
                )
              )),
            showlegend=False,
        )

    fig = dict( data=data, layout=layout )
    outpath = 'C:\\Users\\flin\\PycharmProjects\\wisib\\'+'plot.html'
    plotly.offline.plot(fig, filename=outpath, auto_open=False)
    return outpath

def inputDamge(damagepath, nood_coor, beam_sti):
    df_dam = pd.read_csv(damagepath, ',')
    df_ndcoor = pd.read_csv(nood_coor, ',')
    df_bmsti = pd.read_csv(beam_sti, ',')

    dam_E1 = []
    dam_E2 = []
    list_coor = []
    list_delm = []

    for i in range(0, len(df_dam)):

        dam_e1 = 0
        dam_e2 = 0

        dam1 = df_dam.iloc[i, 1]
        dam2 = df_dam.iloc[i, 2]
        # print(dam1, dam2)

        for j in range(0, len(df_ndcoor)):
            node_x = df_ndcoor.iloc[j,1]
            if dam1 < node_x:
                dam_e1 = j - 1
                dam_E1.append(dam_e1)
                # print('---', dam_e1)
                break

        for j in range(0, len(df_ndcoor)):
            node_x = df_ndcoor.iloc[j, 1]
            if dam2 < node_x:
                dam_e2 = j
                dam_E2.append(dam_e2)
                # print('---', dam_e2)
                break

        # the damaged element for plot
        df_ndcoor_d = df_ndcoor.iloc[dam_e1:dam_e2+1, :]
        list_coor.append(df_ndcoor_d)

        # report the damaged element number
        node_nr1 = df_ndcoor['Node_Nr'][dam_e1]
        node_nr2 = df_ndcoor['Node_Nr'][dam_e2]
        elem1 = df_bmsti[df_bmsti['Node_Start'] == int(node_nr1)].index[0]
        elem2 = df_bmsti[df_bmsti['Node_End'] == int(node_nr2)].index[0]
        dam_elem = df_bmsti.iloc[elem1:elem2 + 1, :]
        dam_elem_out = dam_elem['Beam_Nr'].to_frame().T.values.tolist()
        for j in dam_elem_out[0]:
            list_delm.append(j)
            # print(j)

    html = _plot3d(df_ndcoor, list_coor)

    outpath = 'C:\\Users\\flin\\PycharmProjects\\wisib\\csv_Bank\\para0.csv'
    list_delm.sort()
    df = pd.DataFrame(list_delm).T
    df.to_csv(outpath)

    return html


if __name__ == '__main__':
    nood_coor = 'C:\\Users\\flin\\PycharmProjects\\wisib\\csv_Bank\\node_coor.csv'
    beam_sti = 'C:\\Users\\flin\\PycharmProjects\\wisib\\csv_Bank\\beam_sti.csv'
    damage = 'C:\\Users\\flin\\PycharmProjects\\wisib\\csv_Bank\\damage.csv'
    # beam_geo = 'C:\\Users\\flin\\PycharmProjects\\wisib\\csv_Bank\\beam_geo.csv'
    # plot3d(nood_coor)
    inputDamge(damage, nood_coor, beam_sti)
