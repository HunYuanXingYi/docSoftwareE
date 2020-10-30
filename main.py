from UI.MainWindow import MainWindow
from PyQt5.QtWidgets import QApplication
import sys

app = QApplication(sys.argv)
main = MainWindow()
main.show()
sys.exit(app.exec_())
