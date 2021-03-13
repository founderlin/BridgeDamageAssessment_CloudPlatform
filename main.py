from SOFiKit.conc import *
from SOFiKit.node import *
from SOFiKit.beam import *
from SOFiKit.spt import *

inpath = "C:/Users/flin/PycharmProjects/wisib/SOFI/esslingen.cdb"
outpath =  "C:/Users/flin/PycharmProjects/wisib/WareHouse/demo.cdb"

dll, index = concDLL(inpath, outpath)
flist = setMethode(dll)
#
# # --- get nodes coord info ---
getNodeGeo(index, flist)
#
# --- set nodes ---
# setNode(index, flist)
#
# --- get beam geo info ---
getBeamGeo(index, flist)

# --- set beam stiffness ---
# beam_nr_list = [11004, 11004, 11005, 11005, 11006, 11006]
# beam_x_list = [0, 2.0, 0, 2.0, 0, 2.0]
# eiy_list = [0.5, 0.2, 0.3, 0.4, 1.5, 2]
# setBeamSTI(index, flist, beam_nr_list , beam_x_list, eiy=eiy_list)

# --- get section stress point ---
# getSectSPT(index, flist)
closeDB(dll)


