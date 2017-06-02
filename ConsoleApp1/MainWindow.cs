using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllodsCalc
{
	public partial class MainWindow : Form
	{
		private Controller controller;

		public MainWindow()
		{
			InitializeComponent();
			controller = new Controller(this);
		}

		private void button_Click(object sender, EventArgs e)
		{
			controller.FireButtonClick();
		}
	}
}
