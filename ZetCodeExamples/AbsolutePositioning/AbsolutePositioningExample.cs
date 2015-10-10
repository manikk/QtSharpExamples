using System;
using QtGui;
using QtWidgets;
namespace AbsolutePositioning
{
	public class AbsolutePositioningExample:QWidget
	{
		public AbsolutePositioningExample ()
		{
			WindowTitle = "ZetCode Examples : Absolute Positioning";

			InitUI ();

			Resize (600, 200);
			Move (300, 200);
			Show ();
		}

		private void InitUI()
		{
			//StyleSheet = "QWidget { background-color : #414141 }";

			QPixmap image1 = new QPixmap ("images/periya_kovil.jpeg");
			QPixmap image2 = new QPixmap ("images/western_ghats.jpeg");

			QLabel label1 = new QLabel (this);
			label1.Pixmap = image1;
			label1.Move (20, 20);
			label1.ToolTip = "தஞ்சை பெரிய கோவில் - Tanjore Temple";

			QLabel label2 = new QLabel (this);
			label2.Pixmap = image2;
			label2.ToolTip = "மேற்கு தொடர்ச்சி மலை - Western Ghats";
			label2.Move (320, 20);

		}

		[STAThread]
		public static unsafe int Main(string[] args)
		{
			QApplication application = Shared.QApplicationSingleton.GetQApplication(args);
			AbsolutePositioningExample app = new AbsolutePositioningExample ();
			return QApplication.Exec ();
		}
	}
}

