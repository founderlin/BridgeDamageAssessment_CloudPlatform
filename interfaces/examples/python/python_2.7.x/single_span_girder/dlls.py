#+============================================================================+
#| Company:   SOFiSTiK AG                                                     |
#| Version:   SOFiSTIK 2018                                                   |
#+============================================================================+

import os  # for the environment variable necessary, this is a great tool
import platform  # checks the python platform
from ctypes import *  # read the functions from the cdb


# This example has been tested with python 2.7
print "The path variable=", os.environ["Path"]
print "Python architecture=", platform.architecture()   # Check the python platform (32bit or 64bit)
sofPlatform = str(platform.architecture())


# Get the dlls (32bit or 64bit dll)
if sofPlatform.find("32Bit") < 0:
    # Set environment variable for the dll files
    print "Hint: 64bit dlls are used"
    path = os.environ["Path"]
    dllPath = "C:\\Program Files\\SOFiSTiK\\2018\\SOFiSTiK 2018\\interfaces\\64bit"   # 64bit dlls
    dllPath += ";"
    dllPath += "C:\\Program Files\\SOFiSTiK\\2018\\SOFiSTiK 2018"   # other necessary dlls
    os.environ["Path"] = dllPath + ";" + path

    # Get the dll functions
    myDLL = cdll.LoadLibrary("cdb_w50_x64.dll")
    py_sof_cdb_get = cdll.LoadLibrary("cdb_w50_x64.dll").sof_cdb_get
    py_sof_cdb_get.restype = c_int

    py_sof_cdb_kenq = cdll.LoadLibrary("cdb_w50_x64.dll").sof_cdb_kenq_ex
    py_sof_cdb_kexist = cdll.LoadLibrary("cdb_w50_x64.dll").sof_cdb_kexist
else:
     # Set environment variable for the dll files
    print "Hint: 32bit dlls are used"
    path = os.environ["Path"]
    dllPath = "C:\\Program Files\\SOFiSTiK\\2018\\SOFiSTiK 2018\\interfaces\\32bit"   # 32bit dlls
    os.environ["Path"] = dllPath + ";" + path

    # Get the dll functions
    myDLL = cdll.LoadLibrary("cdb_w31.dll")
    py_sof_cdb_get = cdll.LoadLibrary("cdb_w31.dll").sof_cdb_get
    py_sof_cdb_get.restype = c_int

    py_sof_cdb_kenq = cdll.LoadLibrary("cdb_w31.dll").sof_cdb_kenq_ex
    py_sof_cdb_kexist = cdll.LoadLibrary("cdb_w31.dll").sof_cdb_kexist

# Connect to CDB
Index = c_int()
cdbIndex = 99
fileName = "S:\\test\\single_span_girder.cdb"  # Set the CDB Path
Index.value = myDLL.sof_cdb_init(fileName, cdbIndex)  # important: Unicode call!

cdbStat = c_int()  # get the CDB status
cdbStat.value = myDLL.sof_cdb_status(Index.value)

# Print the Status of the CDB
cdbStat.value = myDLL.sof_cdb_status(Index.value)
if cdbStat.value == 0:
    print "CDB closed successfully, status = 0"



