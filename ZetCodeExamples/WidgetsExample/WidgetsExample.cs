using System;
using QtGui;
using QtWidgets;

namespace WidgetsExample
{
	public class WidgetsExample : QWidget
	{

		private QColor color;
		private QPushButton redButton;
		private QPushButton greenButton;
		private QPushButton blueButton;
		private QWidget colorBoxWidget;

		public WidgetsExample ()
		{
			WindowTitle = "ZetCode Examples : Widgets";
			Resize (350, 300);
			InitUI ();
			Show ();
		}

		private void InitUI()
		{
			QVBoxLayout vBox = new QVBoxLayout (this);
			vBox.AddWidget (InitCheckBox());
			vBox.AddWidget (InitQLabel());
			vBox.AddWidget (InitQLineEdit());
			vBox.AddWidget (InitToggleButtons());
			vBox.AddWidget (InitQComboBox());
			vBox.AddStretch (1);

		}

		private QGroupBox InitCheckBox()
		{
			QGroupBox groupBox = new QGroupBox ("QCheckBox", this);

			QVBoxLayout vBox1 = new QVBoxLayout ();
			QCheckBox checkBox = new QCheckBox ("Show Title", this);
			checkBox.Checked = true;
			checkBox.StateChanged += ShowTitle;

			vBox1.AddWidget (checkBox);

			groupBox.Layout = vBox1;

			return groupBox;
		}

		private QGroupBox InitQLabel()
		{
			String str = @"Little boxes on the hillside,
Little boxes made of ticky tacky,
Little boxes on the hillside,
Little boxes all the same.

There's a green one and a pink one 
And a blue one and a yellow one,
And they're all made out of ticky tacky
And they all look just the same.";

			QGroupBox groupBox = new QGroupBox ("QLabel", this);
			QVBoxLayout vBox = new QVBoxLayout ();
			QLabel label = new QLabel (str, this);	
			label.Font = new QFont("Myriad Pro", 9);
			vBox.AddWidget (label);
			groupBox.Layout = vBox;

			return groupBox;
		}

		private QGroupBox InitQLineEdit()
		{

			QGroupBox groupBox = new QGroupBox ("QLineEdit", this);
			QVBoxLayout vBox = new QVBoxLayout ();
			QLabel label = new QLabel ("Change the text in Line Edit", this);
			QLineEdit lineEdit = new QLineEdit (this);
			lineEdit.TextChanged += (string txt) => {
				label.Text = txt;
				label.AdjustSize();
			};
			vBox.AddWidget (lineEdit);
			vBox.AddWidget (label);

			groupBox.Layout = vBox;
			return groupBox;
		}

		private QGroupBox InitToggleButtons()
		{

			var groupBox = new QGroupBox ("Toggle Buttons", this);
			color = new QColor ();
			redButton = new QPushButton ("Red", this);
			greenButton = new QPushButton ("Green", this);
			blueButton = new QPushButton ("Blue", this);
			colorBoxWidget = new QWidget (this);
			colorBoxWidget.StyleSheet = "QWidget { background-color: black }";

			redButton.Toggled += OnToggled;
			greenButton.Toggled += OnToggled;
			blueButton.Toggled += OnToggled;

			redButton.Checkable = true;
			greenButton.Checkable = true;
			blueButton.Checkable = true;

			QHBoxLayout hBox = new QHBoxLayout ();
			QVBoxLayout vBox = new QVBoxLayout ();

			vBox.AddWidget (redButton);
			vBox.AddWidget (greenButton);
			vBox.AddWidget (blueButton);

			hBox.AddLayout (vBox);
			hBox.AddWidget (colorBoxWidget);

			groupBox.Layout = hBox;

			return groupBox;
		}

		private QGroupBox InitQComboBox()
		{
			var groupBox = new QGroupBox ("QComboBox", this);
			QVBoxLayout vBox = new QVBoxLayout ();
			QComboBox comboBox = new QComboBox (this);
			QLabel label = new QLabel ("Silence is a source of great strength.", this);

			comboBox.AddItem ("Silence is a source of great strength.");
			comboBox.AddItem ("From caring comes courage.");
			comboBox.AddItem ("Mastering yourself is true power.");
			comboBox.AddItem ("To the mind that is still, the whole universe surrenders.");
			comboBox.AddItem ("Be the chief but never the lord.");
			comboBox.AddItem ("He who is contented is rich.");
			comboBox.AddItem ("He who knows himself is enlightened.");
		
			comboBox.ActivatedText += (string obj) => {
				label.Text = obj;
			};
		
			vBox.AddWidget (comboBox);
			vBox.AddWidget (label);
			
			groupBox.Layout = vBox;
			return groupBox;
		}

		public void ShowTitle(int state)
		{
			if(state == (int) QtCore.Qt.CheckState.Checked) {
				WindowTitle = "ZetCode Examples : Widgets";
			}else{
				WindowTitle = "";
			}
		}

		public void OnToggled(bool toggleStatus)
		{

			int red = redButton.Checked ? 255 : 0;
			int green = greenButton.Checked ? 255 : 0;
			int blue = blueButton.Checked ? 255 : 0;

			color = new QColor (red, green, blue);
			var str = color.Name();
			string sheet = String.Format ( "QWidget {{background-color:{0} }}", str);
			colorBoxWidget.StyleSheet = sheet;
	
		}

		public static unsafe int Main(String[] args)
		{
			QApplication qApp = Shared.QApplicationSingleton.GetQApplication (args);
			WidgetsExample widgetsExample = new WidgetsExample ();

			return QApplication.Exec ();
		}
	}

}

