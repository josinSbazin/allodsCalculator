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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void stateInputLabel1_Click(object sender, EventArgs e)
		{

		}
	}
}
