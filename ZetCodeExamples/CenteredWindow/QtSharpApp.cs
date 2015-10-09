using System;
using QtCore;
using QtWidgets;

namespace ToolTip
{
	public class QtSharpApp:QWidget
	{

		const int WIDTH = 400;
		const int HEIGHT = 150;

		public QtSharpApp ()
		{
			WindowTitle = "ZetCode Example : Centered Widget";
			ToolTip = "This is a QtWidget";
			Resize (WIDTH, HEIGHT);
			Center ();
			Show ();
		}

		private void Center()
		{
			QDesktopWidget desktopWiget = new QDesktopWidget ();
			int centerX = (desktopWiget.Width - WIDTH) / 2;
			int centerY = (desktopWiget.Height - HEIGHT) / 2;

			Move (centerX, centerY);
		}



		[STAThread]
		public static void Main(string[] args)
		{

			QApplication application = Shared.QApplicationSingleton.GetQApplication(args);
			QtSharpApp app = new QtSharpApp ();
			QApplication.Exec ();
		}
	}

	
}

