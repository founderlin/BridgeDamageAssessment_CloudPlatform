import os
# from SOFiKit.sofistik_daten import *
from ctypes import *
from shutil import copy2

def copyCDB(wayin, wayout):
    copy2(wayin, wayout)

def concDLL(musterpath, copypath):
    # Establish the connection to CDB
    path = os.environ['Path']
    dllPath = "D:/SOFiSTiK/2018/SOFiSTiK 2018/interfaces/64bit"
    # dllPath = "C:/Users/flin/PycharmProjects/wisib/interfaces/64bit"
    dllPath += ";"
    dllPath += "D:/SOFiSTiK/2018/SOFiSTiK 2018"  # other necessary dlls
    # dllPath += "C:/Users/flin/PycharmProjects/wisib"
    os.environ['Path'] = dllPath + ';' + path

    # Read the dll file
    dll = 'cdb_w_edu50_x64.dll'
    # dll = 'cdb_w50_x64.dll'
    myDLL = cdll.LoadLibrary(dll)

    # Connect to CDB
    Index = c_int()
    cdbIndex = 99

    copy2(musterpath, copypath)
    cdbpath = copypath

    Index.value = myDLL.sof_cdb_init(cdbpath.encode('ascii'), cdbIndex)       # important: Unicode call! Index is a new initiated database.
    cdbStat = c_int()                                # get the CDB status
    cdbStat.value = myDLL.sof_cdb_status(Index.value)
    print("Index.value "+str(Index.value))
    print('Database is already connected')
    print('CDB status: ' + str(cdbStat.value))

    return myDLL, Index

def setMethode(myDLL):
    py_sof_cdb_get = myDLL.sof_cdb_get
    py_sof_cdb_get.restype = c_int

    py_sof_cdb_put = myDLL.sof_cdb_put
    py_sof_cdb_put.restype = c_int

    py_sof_cdb_free = myDLL.sof_cdb_free_ex
    py_sof_cdb_free.restype = None

    py_sof_cdb_rewind = myDLL.sof_cdb_rewind_ex
    py_sof_cdb_rewind.restype = c_int

    py_sof_cdb_kenq = myDLL.sof_cdb_kenq_ex
    py_sof_cdb_kenq.restype = None

    func_list = (py_sof_cdb_get, py_sof_cdb_put, py_sof_cdb_free, py_sof_cdb_rewind, py_sof_cdb_kenq)
    return func_list

def closeDB(myDLL):
    myDLL.sof_cdb_close(0)

if __name__ == '__main__':
    # cdbpath = "C:/Users/flin/PycharmProjects/wisib/SOFI/esslingen.cdb"
    cdbpath = "C:/Users/flin/PycharmProjects/wisib/SOFI/test2/esslingen.cdb"
    copypath = "C:/Users/flin/PycharmProjects/wisib/SOFI/out.cdb"
    dll, index = concDLL(cdbpath, copypath)
    get, put, free, rewind, kenq = setMethode(dll)