using System;
using QtGui;
using QtWidgets;
using QtCore.Qt;

namespace LayoutBottomRightCorner
{
	public class LayoutBottomRightCorner : QWidget
	{
		public LayoutBottomRightCorner ()
		{
			WindowTitle = "ZetCode Examples : Button Bottom Right Corner";

			InitUI ();

			Resize (300, 200);
			Move (300, 300);

			Show ();
		}

		private void InitUI()
		{
			QVBoxLayout vBox = new QVBoxLayout (this);
			QHBoxLayout hBox = new QHBoxLayout ();

			QPushButton okBtn = new QPushButton ("Ok", this);
			QPushButton applyBtn = new QPushButton ("Apply", this);

			hBox.AddWidget (okBtn, 1, AlignmentFlag.AlignRight);
			hBox.AddWidget (applyBtn);

			vBox.AddStretch (1);
			vBox.AddLayout (hBox);

		}

		[STAThread]
		public static int Main(String[] args)
		{
			QApplication application = Shared.QApplicationSingleton.GetQApplication(args);
			LayoutBottomRightCorner app = new LayoutBottomRightCorner ();
			return QApplication.Exec ();
		}
	}
}

