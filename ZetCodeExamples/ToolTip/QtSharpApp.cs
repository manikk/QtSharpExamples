using System;
using QtCore;
using QtWidgets;

namespace ToolTip
{
	public class QtSharpApp:QWidget
	{
		public QtSharpApp ()
		{
			WindowTitle = "ZetCode Example : ToolTip";
			ToolTip = "This is a ToolTip";
			Resize (250, 150);
			Show ();
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

