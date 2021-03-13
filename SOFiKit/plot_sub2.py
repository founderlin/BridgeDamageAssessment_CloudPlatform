import plotly
import plotly.graph_objects as go
from plotly.subplots import make_subplots
import pandas as pd
import numpy as np

# import data

def plotData(benchmark, deflections, statsistik, d):
    df0 = pd.read_csv(benchmark)
    lnum = df0.T.values.tolist()[1]
    bchm = df0.T.values.tolist()[2]

    lc_num = len(df0)
    ones = np.ones(lc_num)

    fig = make_subplots(rows=1, cols=2, column_widths=[0.7, 0.3],
                        subplot_titles=("Simulation results and monitoring data",
                                        "Distribution of machting points"))

    for i in range(1, 12):
        df1 = pd.read_csv(deflections +
                          'var_'+str(i)+'.csv')
        simv = df1.iloc[:,1:].values.tolist()[0]
        minus = [i * -1 for i in simv]
        fig.add_trace(go.Scatter(x=lnum,
                      y=minus,
                      mode='markers',
                      marker=dict(size=ones*20, symbol="circle-dot")
        ), row=1, col=1)


    # benchmark
    fig.add_trace(go.Scatter(
            x=lnum,
            y=bchm,
            mode='markers',
            marker=dict(size=ones*10, symbol="hourglass", color='rgba(205, 85, 85, 1)'),
            error_y=dict(
                type='percent', # value of error bar given as percentage of y value
                value=d*100,
                visible=True)
        ), row=1, col=1)

    fig.update_xaxes(
                     ticks="outside", title_text='Load case',
                     tickwidth=2, tickcolor='crimson', ticklen=2, dtick=1,
                     row=1, col=1)
    fig.update_yaxes(
                     range=[-5, 30],
                     ticks="outside", title_text='Bridge deflection',
                     tickwidth=2, tickcolor='crimson', ticklen=2, dtick=2,
                     row=1, col=1)


    xl = np.arange(1, len(statsistik)+1)
    yl = statsistik

    fig.add_trace(go.Bar(x=xl, y=yl), row=1, col=2)

    fig.update_traces(marker_color='rgb(76,200,224)', marker_line_color='rgb(8,48,107)',
                      marker_line_width=1.5, opacity=0.6, row=1, col=2)
    fig.update_xaxes(ticks="outside", title_text='Model variant',
                     tickwidth=2, tickcolor='crimson', ticklen=2, dtick=1,
                     row=1, col=2)
    fig.update_yaxes(ticks="outside", title_text='Count of matching point',
                     tickwidth=2, tickcolor='crimson', ticklen=2, dtick=1,
                     row=1, col=2)

    fig.update_layout(showlegend=False)
    outpath = 'C:\\Users\\flin\\PycharmProjects\\wisib\\' + 'data.html'
    plotly.offline.plot(fig, filename=outpath, auto_open=False)

    # fig.show()

if __name__ == '__main__':
    benchmark = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/benchmark.csv'
    deflections = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/deflection/'
    stsc = [0, 6, 7, 3, 1, 1, 1, 1, 0, 0, 0]
    d = 0.3
    plotData(benchmark, deflections, stsc, d)