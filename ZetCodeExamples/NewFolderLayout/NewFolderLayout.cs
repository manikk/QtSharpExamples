using System;
using QtGui;
using QtWidgets;

namespace NewFolderLayout
{
	public class NewFolderLayout : QWidget
	{
		public NewFolderLayout ()
		{
			WindowTitle = "ZetCode Examples : New Folder Layout";
			Resize (400, 200);
			Move (300, 300);
			InitUI ();
			Show ();
		}

		private void InitUI()
		{
			QGridLayout grid = new QGridLayout (this);

			QLabel nameLabel = new QLabel ("Name", this);
			QLineEdit nameEdit = new QLineEdit (this);
			QTextEdit textEdit = new QTextEdit (this);

			QPushButton okButton = new QPushButton ("Ok", this);
			QPushButton closeButton = new QPushButton ("Close", this);

			grid.AddWidget (nameLabel, 0, 0);
			grid.AddWidget (nameEdit, 0, 1, 1, 3);
			grid.AddWidget (textEdit, 1, 0, 2, 4);
			grid.SetColumnStretch (1, 1);
			grid.AddWidget (okButton, 4, 2);
			grid.AddWidget (closeButton, 4, 3);
		}


		public static unsafe int Main(String[] args)
		{
			QApplication qApp = Shared.QApplicationSingleton.GetQApplication (args);
			NewFolderLayout app = new NewFolderLayout ();
			return QApplication.Exec ();
		}
	}
}

