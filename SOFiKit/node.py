from SOFiKit.sofistik_daten import *
from SOFiKit.conc import *
import pandas as pd
import os

def concDLL(varpath):
    # Establish the connection to CDB
    path = os.environ['Path']
    dllPath = "D:/SOFiSTiK/2018/SOFiSTiK 2018/interfaces/64bit"
    # dllPath = "C:/Users/flin/PycharmProjects/wisib/interfaces/64bit"
    dllPath += ";"
    dllPath += "D:/SOFiSTiK/2018/SOFiSTiK 2018"  # other necessary dlls
    # dllPath += "C:/Users/flin/PycharmProjects/wisib"
    os.environ['Path'] = dllPath + ';' + path

    # Read the dll file
    # dll = 'cdb_w_edu50_x64.dll'
    dll = 'cdb_w50_x64.dll'
    myDLL = cdll.LoadLibrary(dll)

    # Connect to CDB
    Index = c_int()
    cdbIndex = 99

    Index.value = myDLL.sof_cdb_init(varpath.encode('ascii'), cdbIndex)       # important: Unicode call! Index is a new initiated database.
    cdbStat = c_int()                                # get the CDB status
    cdbStat.value = myDLL.sof_cdb_status(Index.value)
    print('Variant Database is already connected')
    print('CDB status: ' + str(cdbStat.value))

    return myDLL, Index


def getNodeDisp(Index, func_list, j):
    get = func_list[0]
    free = func_list[2]
    rewind = func_list[3]
    loadcase = 2001 + j

    ndisp_nr = []
    ndisp_uz = []

    n_disp = CN_DISP()
    ie = c_int(0)
    RecLen = c_int(sizeof(n_disp))


    while ie.value < 2:
        ie.value = get(Index, 24, int(loadcase), byref(n_disp), byref(RecLen), 1)
        free(Index, 24, 0)
        ndisp_nr.append(n_disp.m_nr)
        ndisp_uz.append(n_disp.m_uz*-1000)

    rewind(Index, 24, 0)

    return ndisp_nr, ndisp_uz

def setNode(Index, func_list):
    get = func_list[0]
    put = func_list[1]
    free = func_list[2]
    rewind = func_list[3]
    # set an instance of CNODE
    node = CNODE()
    ie = c_int(0)
    RecLen = c_int(sizeof(node))
    # print(ie.value)
    while ie.value < 2:
        ie.value = get(Index, 20, 0, byref(node), byref(RecLen), 1)
        free(Index, 20, 0)
        if node.m_nr == 5:
            node.m_xyz[0] = node.m_xyz[0] + 100
        print(
                str(node.m_nr) + ' | ' +
                str(node.m_xyz[0]) + ', ' +
                str(node.m_xyz[1]) + ', ' +
                str(node.m_xyz[2]))
        put(Index, 20, 0, byref(node), byref(RecLen), -1)
        free(Index, 20, 0)
    rewind(Index, 20, 0)



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
        # print(
        #     str(node.m_nr) + ' | ' +
        #     str(node.m_xyz[0]) + ', ' +
        #     str(node.m_xyz[1]) + ', ' +
        #     str(node.m_xyz[2]))
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

    node_nr.pop(0)
    node_x.pop(0)
    node_y.pop(0)
    node_z.pop(0)
    for i in range(0, 10):
        node_nr.pop(-1)
        node_x.pop(-1)
        node_y.pop(-1)
        node_z.pop(-1)

    data = {'Node_Nr': node_nr,
            'Coor_X': node_x,
            'Coor_Y': node_y,
            'Coor_Z': node_z}

    df = pd.DataFrame(data)
    outpath = 'csv_Bank/node_coor.csv'
    df.to_csv(outpath, ',')

    return outpath

def getDelfection(inpath, outpath, num_lc, senser_list):
    data = []
    dll, index = concDLL(inpath)
    flist = setMethode(dll)
    for j in range(0, int(num_lc)):
        ndisp_nr, ndisp_uz = getNodeDisp(index, flist, j)
        if j == 0:
            data.append(ndisp_nr)
        data.append(ndisp_uz)
    df = pd.DataFrame(data).T
    df.ix[:, 0] = df.ix[:, 0].astype(int)
    print(df)
    df_out = df.iloc[senser_list, 1:]
    df_out.to_csv(outpath)


if __name__ == '__main__':
    num_lc = 17
    num_mv = 25
    senser_list = [8]
    for i in range(1, int(num_mv+1)):
    # for i in range(26, 26+int(num_mv + 1)):
        inpath = "C:/Users/flin/PycharmProjects/wisib/" \
                 "WareHouse/var_" + str(i) + ".cdb"
        outpath = "C:/Users/flin/PycharmProjects/wisib/" \
                  "csv_Bank/dflc2/var_" + str(i) + ".csv"
        getDelfection(inpath, outpath, num_lc, senser_list)