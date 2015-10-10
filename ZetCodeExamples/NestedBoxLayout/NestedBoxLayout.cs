using System;
using QtGui;
using QtWidgets;
using QtCore.Qt;

namespace NestedBoxLayout
{
	public class NestedBoxLayout : QWidget
	{
		public NestedBoxLayout ()
		{
			WindowTitle = "ZetCode Examples : Nested Box Layouts";
			InitUI ();
			Resize (350, 300);
			Move (300, 300);
			Show ();
		}

		private void InitUI()
		{
			QVBoxLayout vBox = new QVBoxLayout (this);

			QVBoxLayout vBox1 = new QVBoxLayout ();

			QHBoxLayout hBox1 = new QHBoxLayout ();
			QHBoxLayout hBox2 = new QHBoxLayout ();

			QLabel winLabel = new QLabel ("Windows", this);
			QTextEdit textEdit = new QTextEdit (this);
			textEdit.Enabled = false;

			QPushButton activateButton = new QPushButton ("Activate", this);
			QPushButton closeButton = new QPushButton ("Close", this);
			QPushButton helpButton = new QPushButton ("Help", this);
			QPushButton okButton = new QPushButton ("Ok", this);

			vBox.AddWidget (winLabel);

			vBox1.AddWidget (activateButton);
			vBox1.AddWidget (closeButton, 0, AlignmentFlag.AlignTop);

			hBox1.AddWidget (textEdit);
			hBox1.AddLayout (vBox1);

			vBox.AddLayout (hBox1);

			hBox2.AddWidget (helpButton);
			hBox2.AddStretch (1);
			hBox2.AddWidget (okButton);

			vBox.AddLayout (hBox2, 1);

			Layout = vBox;

			
		}

		[STAThread]
		public static unsafe int Main(String[] args)
		{
			QApplication application = Shared.QApplicationSingleton.GetQApplication (args);

			NestedBoxLayout app = new NestedBoxLayout ();

			return QApplication.Exec ();

		}
	}


}

