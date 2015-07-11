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
	public partial class PlantillaBase : Form
	{
		public PlantillaBase()
		{
			InitializeComponent();

			KeyPreview = true;

			KeyUp += (s, e) =>
				{
					// Al presionar ESC se cierra el formulario.
					if (e.KeyCode == Keys.Escape)
						Close();
				};
		}
	}
}
