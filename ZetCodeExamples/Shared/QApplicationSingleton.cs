using System;
using System.Collections.Generic;
using QtWidgets;

namespace Shared
{
	public class QApplicationSingleton
	{
		public static QApplication app = null;

		public static unsafe QApplication GetQApplication(String[] args)
		{

			if (app == null) {
				List<String> strList = new List<String> (args);
				CStringArray cStrArray = new CStringArray (strList);
				cStrArray.Alloc ();
				int argc = args.Length;
				char** argv = (char**)cStrArray.Address ();
				app = new QApplication (ref argc, argv);
			}

			return app;
		}


	}
}

