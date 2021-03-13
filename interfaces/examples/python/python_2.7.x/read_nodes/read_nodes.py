# +============================================================================+
# | Company:   SOFiSTiK AG                                                     |
# | Version:   SOFiSTIK 2018                                                   |
# +============================================================================+

import os  # for the environment variable necessary, this is a great tool
import platform  # checks the python platform
from ctypes import *  # read the functions from the cdb
# from sofistik_daten import * 

# Installation folder
installation_folder = r"C:\sofistik_installation\2018\SOFiSTiK 2018"

# This is the structure of the CDB for "@Rec: 020/00 NODE|Nodes"
# All structures can be found in sofistik_daten.py file
# You can include the sofistik_daten by using "from sofistik_daten import *"
class CNODE(Structure):
    _fields_ = [
        ('m_NR', c_int),
        ("m_INR", c_int),
        ("m_KFIX", c_int),
        ("m_NCOD", c_int),
        ("m_XYZ", c_float * 3)
    ]

# Set cnode to CNODE Structure
cnode = CNODE()

# This example has been tested with python 2.7
print("The path variable=", os.environ["Path"])

# Check the python platform (32bit or 64bit)
print("Python architecture=", platform.architecture())
sofPlatform = str(platform.architecture())

# Get the dlls (32bit or 64bit dll)
if sofPlatform.lower().find("64bit") != -1:
    # Set environment variable for the dll files
    print("Hint: 64bit DLLs are used")
    path = os.environ["Path"]
    dllPath = installation_folder + r"\interfaces\64bit"  # 64bit dlls
    dllPath += ";"
    dllPath += installation_folder  # other necessary dlls
    os.environ["Path"] = dllPath + ";" + path

    # Get the dll functions
    myDLL = cdll.LoadLibrary(installation_folder + r"\libmmd.dll")
    myDLL = cdll.LoadLibrary(installation_folder + r"\libifcoremd.dll")
    myDLL = cdll.LoadLibrary("cdb_w50_x64.dll")
    py_sof_cdb_get = cdll.LoadLibrary("cdb_w50_x64.dll").sof_cdb_get
    py_sof_cdb_get.restype = c_int

    py_sof_cdb_kenq = cdll.LoadLibrary("cdb_w50_x64.dll").sof_cdb_kenq_ex
elif sofPlatform.lower().find("32bit") != -1:
    # Set environment variable for the dll files
    print("Hint: 32bit DLLs are used")
    path = os.environ["Path"]
    dllPath = installation_folder + r"\interfaces\32bit"  # 32bit dlls
    os.environ["Path"] = dllPath + ";" + path

    # Get the dll functions
    cdll.LoadLibrary(installation_folder + r"\interfaces\32bit\libmmd.dll")
    cdll.LoadLibrary(installation_folder + r"\interfaces\32bit\libifcoremd.dll")
    myDLL = cdll.LoadLibrary("cdb_w31.dll")
    py_sof_cdb_get = cdll.LoadLibrary("cdb_w31.dll").sof_cdb_get
    py_sof_cdb_get.restype = c_int

    py_sof_cdb_kenq = cdll.LoadLibrary("cdb_w31.dll").sof_cdb_kenq_ex

# Connect to CDB
Index = c_int()
cdbIndex = 99

# Set the CDB Path
# e.g. fileName = "S:\\test\\read_nodes.cdb"
fileName = "read_nodes.cdb"

Index.value = myDLL.sof_cdb_init(fileName, cdbIndex)

cdbStat = c_int()  # get the CDB status
cdbStat.value = myDLL.sof_cdb_status(Index.value)

# Print the Status of the CDB
print("CDB Status:" + str(cdbStat.value))

pos = c_int(0)
datalen = c_int(0)

a = c_int()
ie = c_int(0)
datalen.value = sizeof(CNODE)
RecLen = c_int(sizeof(cnode))

"""
do while ie == 0, see cdbase.chm, Returnvalue.
    = 0 -> No error
    = 1 -> Item is longer than Data
    = 2 -> End of file reached
    = 3 -> Key does not exist
"""
while ie.value < 2:
    ie.value = py_sof_cdb_get(Index, 20, 0, byref(cnode), byref(RecLen), 1)

    print("{:10d}{:10d}{:10d}{:10d}{:10.2f}{:10.2f}{:10.2f}".format(
        cnode.m_NR,      # node-number
        cnode.m_INR,     # internal node-number
        cnode.m_KFIX,    # degree of freedoms
        cnode.m_NCOD,    # additional bit code
        cnode.m_XYZ[0],  # x coordinates
        cnode.m_XYZ[1],  # y coordinates
        cnode.m_XYZ[2])  # z coordinates
    )

    # Always read the length of record before sof_cdb_get is called
    RecLen = c_int(sizeof(cnode))

# Close the CDB, 0 - will close all the files
myDLL.sof_cdb_close(0)

# Print again the status of the CDB, if status = 0 -> CDB Closed successfully
cdbStat.value = myDLL.sof_cdb_status(Index.value)
if cdbStat.value == 0:
    print("CDB closed successfully, status = 0")
