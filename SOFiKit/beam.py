from SOFiKit.sofistik_daten import *
from SOFiKit.conc import *
import pandas as pd

def setBeamSTI(Index, func_list, beam_nr, beam_x, **kwargs):
    get = func_list[0]
    put = func_list[1]
    free = func_list[2]
    rewind = func_list[3]

    llen = len(beam_nr)

    fak_ea = kwargs.get('ea', 1)
    fak_gay = kwargs.get('gay', 1)
    fak_gaz = kwargs.get('gaz', 1)
    fak_git = kwargs.get('git', 1)
    fak_eiy = kwargs.get('eiy', 1)
    # print(fak_eiy)
    fak_eiz = kwargs.get('eiz', 1)
    fak_eiyz = kwargs.get('eiyz', 1)
    fak_gayz = kwargs.get('gayz', 1)

    beam_nr0 = []
    beam_pos0 = []
    beam_eiy0 = []

    # set an instance of CNODE
    beam_sti = CBEAM_STI()
    ie = c_int(0)
    i = 0
    RecLen = c_int(sizeof(beam_sti))

    while ie.value < 2:
        while i < llen:
            ie.value = get(Index, 103, 3, byref(beam_sti), byref(RecLen), 1)
            free(Index, 103, 100)
            # print(str(beam_sti.m_nr) + '| ' + str(beam_sti.m_x) + ': ' + str(beam_sti.m_eiy))
            beam_nr0.append(beam_sti.m_nr)
            beam_pos0.append(beam_sti.m_x)
            beam_eiy0.append(beam_sti.m_eiy)

            if beam_sti.m_nr == beam_nr[i] and beam_sti.m_x == beam_x[i]:
                # beam_sti.m_ea = beam_sti.m_ea * fak_ea
                # beam_sti.m_gay = beam_sti.m_gay0 * fak_gay
                print(beam_sti.m_eiy)
                beam_sti.m_eiy = beam_sti.m_eiy * fak_eiy[i]
                print('///', fak_eiy[i])
                print(beam_sti.m_eiy)
                # beam_sti.m_eiz = beam_sti.m_eiz * fak_eiz
                # beam_sti.m_eiy = beam_sti.m_eiy0 * fak_eiy
                put(Index, 103, 3, byref(beam_sti), byref(RecLen), -1)

                i += 1
            # print(str(beam_sti.m_nr) + '| ' + str(beam_sti.m_x) + ': ' + str(beam_sti.m_eiy))
            free(Index, 103, 3)

        if i == llen:
            break

    rewind(Index, 103, 10)

    # for i in range(0,6):
    #     beam_nr0.pop(-1)
    #     beam_pos0.pop(-1)
    #     beam_eiy0.pop(-1)
    #
    # data = {'Beam_Nr': beam_nr0,
    #         'Node_Pos': beam_pos0,
    #         'EIy': beam_eiy0}
    #
    # df = pd.DataFrame(data)
    # outpath = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/beam_sti.csv'
    # df.to_csv(outpath, ',')

    # return outpath


def getBeamGeo(Index, func_list):
    get = func_list[0]
    free = func_list[2]
    rewind = func_list[3]

    beam = CBEAM()
    ie = c_int(0)
    RecLen = c_int(sizeof(beam))

    beam_nr0 = []
    beam_start0 = []
    beam_end0 = []
    beam_x0 = []
    beam_nr = []
    beam_start = []
    beam_end = []
    beam_x = []

    while ie.value < 2:
        ie.value = get(Index, 100, 00, byref(beam), byref(RecLen), 1)
        free(Index, 100, 00)
        beam_nr0.append(beam.m_nr)
        beam_start0.append(beam.m_node[0])
        beam_end0.append(beam.m_node[1])
        beam_x0.append(beam.m_dl)

    rewind(Index, 100, 00)

    listlen = len(beam_nr0)
    for i in range(0, listlen, 3):
        beam_nr.append(beam_nr0[i])
        beam_start.append(beam_start0[i])
        beam_end.append(beam_end0[i])
        beam_x.append(beam_x0[i])

    beam_nr.pop(-1)
    beam_start.pop(-1)
    beam_end.pop(-1)
    beam_x.pop(-1)


    data = {'Beam_Nr': beam_nr,
            'Node_Start': beam_start,
            'Node_End': beam_end,
            'Beam_Len': beam_x
            }

    df = pd.DataFrame(data)
    outpath = 'csv_Bank/beam_sti.csv'
    df.to_csv(outpath, ',')

    return outpath