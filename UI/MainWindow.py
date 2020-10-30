from PyQt5.QtWidgets import *


class MainWindow(QWidget):

    def __init__(self, parent=None):
        QWidget.__init__(self)
        self.setWindowTitle("主菜单")
        self.startButton = QPushButton(parent=self)
        self.resize(1280, 720)

        self.show()
