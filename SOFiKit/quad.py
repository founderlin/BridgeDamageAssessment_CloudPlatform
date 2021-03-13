from SOFiKit.sofistik_daten import *
from SOFiKit.conc import *
import pandas as pd
import os

def getNodeGeo(Index, func_list):
    get = func_list[0]
    free = func_list[2]
    rewind = func_list[3]

    node = CNODE()
    ie = c_int(0)
    RecLen = c_int(sizeof(node))

    node_nr0 = []
    node_x0 = []
    node_y0 = []
    node_z0 = []
    node_nr = []
    node_x = []
    node_y = []
    node_z = []

    while ie.value < 2:
        ie.value = get(Index, 20, 0, byref(node), byref(RecLen), 1)
        free(Index, 20, 0)
        print(
            str(node.m_nr) + ' | ' +
            str(node.m_xyz[0]) + ', ' +
            str(node.m_xyz[1]) + ', ' +
            str(node.m_xyz[2]))
        node_nr0.append(node.m_nr)
        node_x0.append(node.m_xyz[0])
        node_y0.append(node.m_xyz[1])
        node_z0.append(node.m_xyz[2])

    rewind(Index, 20, 0)

    listlen = len(node_nr0)
    for i in range(0, listlen, 1):
        node_nr.append(node_nr0[i])
        node_x.append(node_x0[i])
        node_y.append(node_y0[i])
        node_z.append(node_z0[i])

    # node_nr.pop(0)
    # node_x.pop(0)
    # node_y.pop(0)
    # node_z.pop(0)
    # for i in range(0, 10):
    #     node_nr.pop(-1)
    #     node_x.pop(-1)
    #     node_y.pop(-1)
    #     node_z.pop(-1)

    data = {'Node_Nr': node_nr,
            'Coor_X': node_x,
            'Coor_Y': node_y,
            'Coor_Z': node_z}

    df = pd.DataFrame(data)
    outpath = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/node_coor_2d.csv'
    df.to_csv(outpath, ',')

    # return outpath

def getAreaElem(Index, func_list):
    get = func_list[0]
    free = func_list[2]
    rewind = func_list[3]

    # area = CAREA()
    quad = CQUAD()
    ie = c_int(0)
    RecLen = c_int(sizeof(quad))

    quad_nr0 = []
    quad_n10 = []
    quad_n20 = []
    quad_n30 = []
    quad_n40 = []

    quad_nr = []
    quad_n1 = []
    quad_n2 = []
    quad_n3 = []
    quad_n4 = []

    while ie.value < 2:
        ie.value = get(Index, 200, 0, byref(quad), byref(RecLen), 1)
        free(Index, 200, 0)
        print(
            str(quad.m_nr) + ' | ' +
            str(quad.m_node[0]) + ', ' +
            str(quad.m_node[1]) + ', ' +
            str(quad.m_node[2]) + ', ' +
            str(quad.m_node[3]))
        quad_nr0.append(quad.m_nr)
        quad_n10.append(quad.m_node[0])
        quad_n20.append(quad.m_node[1])
        quad_n30.append(quad.m_node[2])
        quad_n40.append(quad.m_node[3])

    rewind(Index, 200, 0)

    listlen = len(quad_nr0)
    for i in range(0, listlen, 1):
        quad_nr.append(quad_nr0[i])
        quad_n1.append(quad_n10[i])
        quad_n2.append(quad_n20[i])
        quad_n3.append(quad_n30[i])
        quad_n4.append(quad_n40[i])

    # quad_nr.pop(0)
    # quad_n1.pop(0)
    # quad_n2.pop(0)
    # quad_n3.pop(0)
    # quad_n4.pop(0)
    #
    # for i in range(0, 10):
    #     quad_nr.pop(-1)
    #     quad_n1.pop(-1)
    #     quad_n2.pop(-1)
    #     quad_n3.pop(-1)
    #     quad_n4.pop(-1)

    data = {'Node_Nr': quad_nr,
            'Node_1': quad_n1,
            'Node_2': quad_n2,
            'Node_3': quad_n3,
            'Node_4': quad_n4}

    df = pd.DataFrame(data)
    outpath = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/quad_node_2d.csv'
    df.to_csv(outpath, ',')

if __name__ == '__main__':
    cdbpath = "C:\\Users\\flin\\PycharmProjects\\wisib\\SOFI\\Vogelsangbrücke_als_Platte.cdb"
    # cdbpath = "C:\\Users\\flin\\PycharmProjects\\wisib\\SOFI\\esslingen - Kopie.cdb"
    copypath = "C:/Users/flin/PycharmProjects/wisib/SOFI/out2d.cdb"
    dll, index = concDLL(cdbpath, copypath)
    func_list = setMethode(dll)
    getNodeGeo(index, func_list)
    getAreaElem(index, func_list)
    closeDB(dll)