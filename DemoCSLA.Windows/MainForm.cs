using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCSLA.Windows
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var form = new CustomerEditForm())
			{
				form.ShowDialog();
			}
		}

		private void productosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var form = new ProductEditForm())
			{
				form.ShowDialog();
			}
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
