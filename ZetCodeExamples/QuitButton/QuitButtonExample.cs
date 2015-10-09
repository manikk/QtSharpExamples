using System;
using QtGui;
using QtWidgets;

namespace QuitButton
{
	public class QuitButtonExample:QWidget
	{
		public QuitButtonExample ()
		{
			WindowTitle = "Quit Button";
			Resize (250, 150);
			Move (300, 300);

			InitUI ();

			Show ();
		}

		private void InitUI()
		{
			QPushButton button = new QPushButton ("Quit", this);
			button.SetGeometry (50, 40, 80, 20);
			button.Clicked += (obj) => {
				QApplication.Quit();
			};
		}

		public static unsafe int Main(String[] args) 
		{
			QApplication application = Shared.QApplicationSingleton.GetQApplication(args);

			new QuitButtonExample();

			return QApplication.Exec();
		}
	}
}

