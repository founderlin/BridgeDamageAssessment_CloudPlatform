from PyQt5.QtWidgets import QApplication, QMainWindow, QFileDialog
from PyQt5 import QtCore
from gui import Ui_wiSIB

from SOFiKit.conc import *
from SOFiKit.node import *
# from SOFiKit.ident_dt import *
from SOFiKit.ident_dt2 import *
from SOFiKit.beam import *
# from SOFiKit.spt import *
from SOFiKit.psp_input import *
from SOFiKit.output1 import *
from SOFiKit.vari import *


import sys

class MyWindow(QMainWindow, Ui_wiSIB):
    def __init__(self, parent=None):
        super(MyWindow, self).__init__(parent)
        self.setupUi(self)


    '''
    TAB_System
    '''

    # Muster.dat
    @QtCore.pyqtSlot()
    # chose system cdb file
    def on_sys_brw_btn_clicked(self): # on_{BtnName}_clicked
        options = QFileDialog.Options()
        options |= QFileDialog.DontUseNativeDialog
        fileName, _ = QFileDialog.getOpenFileName(self, "Select a *.cdb file", "",
                                                  "All Files (*);;CDBase Files (*.cdb)", options=options)
        if fileName:
            self.sys_in_win.setText(fileName)
            self.cdbpath = fileName

    @QtCore.pyqtSlot()
    # chose damage csv file
    def on_dam_brw_btn_clicked(self):
        options = QFileDialog.Options()
        options |= QFileDialog.DontUseNativeDialog
        fileName, _ = QFileDialog.getOpenFileName(self, "Select a *.csv file", "",
                                                  "All Files (*);;CSV Files (*.csv)", options=options)
        if fileName:
            self.dam_in_win.setText(fileName)
            self.csvpath_dam = fileName

    @QtCore.pyqtSlot()
    def on_sys_imp_btn_clicked(self):
        # 1. import cdb files, generate 3 csv files
        outpath = "C:/Users/flin/PycharmProjects/wisib/WareHouse/demo.cdb"
        dll, index = concDLL(self.cdbpath, outpath)
        flist = setMethode(dll)
        path_node_coor = getNodeGeo(index, flist)
        path_beam_sti = getBeamGeo(index, flist)

        # 2. visualize 3d and list plot
        nood_coor = 'C:\\Users\\flin\\PycharmProjects\\wisib\\' + path_node_coor
        self.beam_sti = 'C:\\Users\\flin\\PycharmProjects\\wisib\\' + path_beam_sti
        html = inputDamge(self.csvpath_dam, nood_coor, self.beam_sti)
        self.Viewer1.load(QtCore.QUrl.fromLocalFile(html))
        self.tab_info_1.append('Info: 3D plot completed.')

    '''
    TAB_Variation
    '''

    @QtCore.pyqtSlot()
    # chose parameters csv file
    def on_para_brw_btn_clicked(self):
        options = QFileDialog.Options()
        options |= QFileDialog.DontUseNativeDialog
        fileName, _ = QFileDialog.getOpenFileName(self, "Select a *.csv file", "",
                                                  "All Files (*);;CSV Files (*.csv)", options=options)
        if fileName:
            self.para_in_win.setText(fileName)
            self.csvpath_para = fileName

    @QtCore.pyqtSlot()
    # chose dat file
    def on_load_brw_btn_clicked(self):
        options = QFileDialog.Options()
        options |= QFileDialog.DontUseNativeDialog
        fileName, _ = QFileDialog.getOpenFileName(self, "Select a *.dat file", "",
                                                  "All Files (*);;Teddy Files (*.dat)", options=options)
        if fileName:
            self.load_in_win.setText(fileName)
            self.psppath = fileName

    @QtCore.pyqtSlot()
    def on_idf_imp_btn_clicked(self):
        # cdbpath = "C:/Users/flin/PycharmProjects/wisib/SOFI/esslingen.cdb"
        # datpath = "C:/Users/flin/PycharmProjects/wisib/SOFI/load.dat"
        # csvpath = "C:/Users/flin/PycharmProjects/wisib/csv_Bank/para1.csv"
        # beam_sti = 'C:\\Users\\flin\\PycharmProjects\\wisib\\csv_Bank\\beam_sti.csv'
        #
        # Variation(cdbpath, datpath, csvpath, beam_sti)
        loadpath = conventor(self.psppath)
        Variation(self.cdbpath, loadpath, self.csvpath_para, self.beam_sti)
        self.tab_info_2.append('Info: Model Variants Generation completed!')

    '''
    TAB_Identification
    '''

    @QtCore.pyqtSlot()
    def on_sim_get_btn_clicked(self):
        num_lc = 17
        self.num_mv = 11
        senser_list = [8]
        for i in range(1, int(self.num_mv + 1)):
            inpath = "C:/Users/flin/PycharmProjects/wisib/" \
                     "WareHouse/var_" + str(i) + ".cdb"
            outpath = "C:/Users/flin/PycharmProjects/wisib/" \
                      "csv_Bank/deflection/var_" + str(i) + ".csv"
            getDelfection(inpath, outpath, num_lc, senser_list)
        self.tab_info_3.append('Info: Simulation results obtained!')

    @QtCore.pyqtSlot()
    def on_mon_get_btn_clicked(self):
        # num_mv = 11
        self.benchmark = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/benchmark.csv'
        self.df0, self.df1 = importData(self.benchmark, self.num_mv)
        self.tab_info_3.append('Info: Monitoring data obtained!')

    # @QtCore.pyqtSlot()
    # def on_mon_get_btn_clicked(self):
    #     num_mv = 2
    #     benchmark = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/benchmark.csv'
    #     self.dot_path = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/tree.dot'
    #     self.df0, self.df1 = importData(benchmark, num_mv)
    #     self.tab_info_3.append('Info: Monitoring data obtained!')

    @QtCore.pyqtSlot()
    def on_sys_idt_btn_clicked(self):
        deflections = 'C:/Users/flin/PycharmProjects/wisib/csv_Bank/deflection/'
        d = 0.3
        identification(self.benchmark, deflections, self.df0, self.df1, d)
        self.tab_info_3.append('Info: Systems identified!')
        self.tab_info_3.append('Info: Plot prepared!')

    # @QtCore.pyqtSlot()
    # def on_sys_idt_btn_clicked(self):
    #     d = 0.1
    #     identification(self.df0, self.df1,self.dot_path, d)
    #     self.tab_info_3.append('Info: Systems identified!')
    #     self.tab_info_3.append('Info: Plot prepared!')

    @QtCore.pyqtSlot()
    def on_bt_plot_btn_clicked(self):
        html1 = "C:/Users/flin/PycharmProjects/wisib/data1.html"
        html2 = "C:/Users/flin/PycharmProjects/wisib/data2.html"
        self.Viewer2.load(QtCore.QUrl.fromLocalFile(html1))
        self.Viewer3.load(QtCore.QUrl.fromLocalFile(html2))
        self.tab_info_3.append('Info: Data ploted!')

    # @QtCore.pyqtSlot()
    # def on_bt_plot_btn_clicked(self):
    #     plotTree(self.dot_path)
    #     pdf = "C:/Users/flin/PycharmProjects/wisib/csv_Bank/tree.dot.pdf"
    #     self.Viewer.load(QtCore.QUrl.fromLocalFile(pdf))
    #     self.tab_info_3.append('Info: Ploted!')

if __name__ == '__main__':
    app = QApplication(sys.argv)
    myWin = MyWindow()
    myWin.show()
    sys.exit(app.exec_())
