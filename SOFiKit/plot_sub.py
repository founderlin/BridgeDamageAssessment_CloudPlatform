import plotly
import plotly.graph_objects as go
from plotly.subplots import make_subplots
import pandas as pd
import numpy as np

# import data

def plotData(benchmark, deflections, statsistik, d, num_mv):
    df0 = pd.read_csv(benchmark)
    lnum = df0.T.values.tolist()[1]
    bchm = df0.T.values.tolist()[2]

    lc_num = len(df0)
    ones = np.ones(lc_num)

    # fig = make_subplots(rows=1, cols=2, column_widths=[0.7, 0.3],
    #                     subplot_titles=("Simulation results and monitoring data",
    #                                     "Distribution of machting points"))
    fig1 = go.Figure()
    fig2 = go.Figure()

    for i in range(1, num_mv+1):
        df1 = pd.read_csv(deflections +
                          'var_'+str(i)+'.csv')
        simv = df1.iloc[:,1:].values.tolist()[0]
        minus = [i * -1 for i in simv]
        fig1.add_trace(go.Scatter(x=lnum,
                      y=minus,
                      mode='markers',
                      marker=dict(size=ones*12, symbol="circle-dot")
        ))


    # benchmark
    fig1.add_trace(go.Scatter(
            x=lnum,
            y=bchm,
            mode='markers',
            marker=dict(size=ones*10, symbol="hourglass", color='rgba(205, 85, 85, 1)'),
            error_y=dict(
                type='percent', # value of error bar given as percentage of y value
                value=d*100,
                visible=True)
        ))

    fig1.update_xaxes(
                     ticks="outside", title_text='Load case',
                     tickwidth=2, tickcolor='crimson', ticklen=2, dtick=1)
    fig1.update_yaxes(
                     range=[-5, 30],
                     ticks="outside", title_text='Bridge deflection',
                     tickwidth=2, tickcolor='crimson', ticklen=2, dtick=2)


    xl = np.arange(1, len(statsistik)+1)
    yl = statsistik

    fig2.add_trace(go.Bar(x=xl, y=yl))

    fig2.update_traces(marker_color='rgb(76,200,224)', marker_line_color='rgb(8,48,107)',
                      marker_line_width=1.5, opacity=0.6)
    fig2.update_xaxes(ticks="outside", title_text='Model variant',
                     tickwidth=2, tickcolor='crimson', ticklen=2, dtick=1)
    fig2.update_yaxes(ticks="outside", title_text='Count of matching points',
                     tickwidth=2, tickcolor='crimson', ticklen=2, dtick=1)

    fig1.update_layout(showlegend=False, title="Simulation results and monitoring data")
    fig2.update_layout(showlegend=False, title="Distribution of machting points (p = " + str(d*100) + "%)")

    outpath1 = 'C:\\Users\\flin\\PycharmProjects\\wisib\\' + 'data1.html'
    outpath2 = 'C:\\Users\\flin\\PycharmProjects\\wisib\\' + 'data2.html'
    plotly.offline.plot(fig1, filename=outpath1, auto_open=False)
    plotly.offline.plot(fig2, filename=outpath2, auto_open=False)

    # fig.show()

if __name__ == '__main__':
    benchmark = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/benchmark.csv'
    deflections = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/deflection/'
    stsc = [0, 6, 7, 3, 1, 1, 1, 1, 0, 0, 0]
    d = 0.3
    plotData(benchmark, deflections, stsc, d)