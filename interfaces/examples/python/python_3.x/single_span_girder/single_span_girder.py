#+============================================================================+
#| Company:   SOFiSTiK AG                                                     |
#| Version:   SOFiSTIK 2018                                                   |
#+============================================================================+

import os  # for the environment variable necessary, this is a great tool
import platform  # checks the python platform
from dlls import *
from ctypes import *  # read the functions from the cdb
from structs import *


# This example has been tested with python 3.5

print ("CDB Status:", cdbStat.value)

# #########################
# #     READ FROM CDB     #
# #########################

"""
do while ie == 0, see cdbase.chm, Returnvalue.
    = 0 -> No error
    = 1 -> Item is longer than Data
    = 2 -> End of file reached
    = 3 -> Key does not exist
"""

# Read the fck value from the CDB
if py_sof_cdb_kexist(1, 1) == 2: # the key exists and contains data
    ie = c_int(0)
    RecLen = c_int(sizeof(mat_conc))
    while ie.value < 2:
        ie.value = py_sof_cdb_get(Index, 1, 1, byref(mat_conc), byref(RecLen), 1)
        if mat_conc.m_id == 1.0:
            fck = mat_conc.m_fck
        RecLen = c_int(sizeof(mat_conc))


# Read fy value from the CDB
if py_sof_cdb_kexist(1, 2) == 2: # the key exists and contains data
    ie = c_int(0)
    RecLen = c_int(sizeof(mat_stee))
    while ie.value < 2:
        ie.value = py_sof_cdb_get(Index, 1, 2, byref(mat_stee), byref(RecLen), 1)
        if mat_stee.m_id == 1.0:
            fy = mat_stee.m_fy
        RecLen = c_int(sizeof(mat_stee))

# Read su, so, h and b values from the CDB
if py_sof_cdb_kexist(9, 1) == 2: # the key exists and contains data
    ie = c_int(0)
    RecLen = c_int(sizeof(sect_rec))
    while ie.value == 0:
        ie.value = py_sof_cdb_get(Index, 9, 1, byref(sect_rec), byref(RecLen), 1)
        if sect_rec.m_id == 10.0:
            b = sect_rec.m_b
            h = sect_rec.m_h
            su = sect_rec.m_su
            so = sect_rec.m_so
        RecLen = c_int(sizeof(sect_rec))


# Read the Med and Ned internal forces from CDB
if py_sof_cdb_kexist(102, 1001) == 2: # the key exists and contains data
    ie = c_int(0)
    Ned = 0.0
    Med = 0.0
    RecLen = c_int(sizeof(beam_foc))
    while ie.value == 0:
        ie.value = py_sof_cdb_get(Index, 102, 1001, byref(beam_foc), byref(RecLen), 1)
        if beam_foc.m_id == 0.0:
            if abs(Ned) < abs(beam_foc.m_n) and abs(beam_foc.m_n < 1e+30):
                Ned = beam_foc.m_n
            if abs(Med) < abs(beam_foc.m_my) and beam_foc.m_my < 1e+30:
                Med = beam_foc.m_my
        RecLen = c_int(sizeof(beam_foc))

# ################################
# #     ITERATION AND DESIGN     #
# ################################

fcd = fck / 1.5 * 0.85
fyd = fy / 1.15
epss = 25.0
epsc = 0.0
Mrd = 0.0
mu = 0.0
alpha = 0.0
xi = 0.0
x = 0
d = h - su
ka = 0.0
z = 0.0
zeta = 0.0
omega = 0.0
As1 = 0.0
Meds = Med - Ned * (h / 2 - su)

while Mrd <= Meds and mu < 0.296:
    if 0 < epsc <= 2:
        alpha = epsc / 12 * (6 - epsc)
    elif 2 < epsc <= 3.5:
        alpha = (3 * epsc - 2) / (3 * epsc)

    # Calculate the Xi value
    xi = epsc / (epss + epsc)

    # Calculate x
    x = xi * d

    # Calculate ka
    if 0 < epsc <= 2:
        ka = (8 - epsc) / (4 * (6 - epsc))
    elif 2 < epsc <= 3.5:
        ka = (epsc * (3 * epsc - 4) + 2) / (2 * epsc * (3 * epsc - 2))

    # Calculate z
    z = d - ka * x

    # Calculate zeta
    zeta = 1 - ka * xi

    # Calculate omega
    omega = alpha * xi

    # Calculate mu
    mu = alpha * xi * zeta

    # Calculate the Mrd value
    Mrd = alpha * xi * d * b * fcd * zeta * d

    # Required reinforcement
    As1 = (1 / fyd) * (omega * b * d * fcd + Ned)

    if epsc == 3.5:
        epss = 25

        while Mrd <= Meds and epss >= 0.0 and mu < 0.296:
            if 0 < epsc <= 2.0:
                alpha = epsc / 12 * (6 - epsc)
            elif 2.0 < epsc <= 3.5:
                alpha = (3 * epsc - 2) / (3 * epsc)

        # Calculate the Xi value
        xi = epsc / (epss + epsc)

        # Calculate x
        x = xi * d

        # Calculate ka
        if 0 < epsc <= 2:
            ka = ((8 - epsc) / (4 * (6 - epsc)))
        elif 2.0 < epsc <= 3.5:
            ka = (epsc * (3 * epsc - 4) + 2) / (2 * epsc * (3 * epsc - 2))

        # Calculate z
        z = d - ka * x

        # Calculate zeta
        zeta = 1 - ka * xi

        # Calculate omega
        omega = alpha * xi

        # Calculate mu
        mu = alpha * xi * zeta

        # Calculate Mrd value
        Mrd = alpha * xi * d * b * fcd * zeta * d

        # Required reinforcement
        As1 = (1 / fyd) * (omega * b * d * fcd + Ned)

        if epss == 0.0:
            print ("Reinforcement reached 0[o/oo], iteration stopped!")

        epss -= 0.001
    epsc += 0.001

# Close the CDB, 0 - will close all the files
myDLL.sof_cdb_close(0)

# ##################
# #     OUTPUT     #
# ##################

print ("Ned = {0} kN".format(str(Ned)))
print ("Med = {0} kN".format(str(Med)))
print ("Meds = {0} kN".format(str(Meds)))

print ("----------------------------")

print ("fcd = {0} kN".format(str(fcd / 1000)))
print ("fyd = {0} kN".format(str(fyd / 1000)))
print ("epsc = {0} o/oo".format(str(Meds)))
print ("epsc = {0} o/oo".format(str(Meds)))
print ("alpha = {0}".format(str(alpha)))
print ("ka = {0}".format(str(ka)))
print ("z = {0} cm".format(str(z * 100)))
print ("zeta = {0}".format(str(zeta)))
print ("omega = {0}".format(str(omega)))
print ("mu = {0}".format(str(mu)))
print ("d = {0} cm".format(str(d * 100)))
print ("Xi = {0}".format(str(xi)))
print ("x = {0} cm".format(str(x * 100)))
print ("Mrd = {0} kNm".format(str(Mrd)))

print ("----------------------------")

print ("As1 = {0} cm".format(str(As1 * 100**2)))

# Print CDB Status
cdbStat.value = myDLL.sof_cdb_status(Index.value)
print ("CDB Status after closing:", cdbStat.value)
