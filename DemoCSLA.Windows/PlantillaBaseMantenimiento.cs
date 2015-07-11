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
	public partial class PlantillaBaseMantenimiento : PlantillaBase
	{
		public PlantillaBaseMantenimiento()
		{
			InitializeComponent();

			toolNew.Click += (s, e) => Nuevo();
			toolEdit.Click += (s, e) => Editar();
			toolSave.Click += (s, e) => Grabar();
			toolCancel.Click += (s, e) => Cancelar();
			toolRefresh.Click += (s, e) => Refrescar();
			Load += (s, e) => Cargar();
		}

		protected virtual void Cargar()
		{
			// Desactivamos todos los controles de edición en el primer contenedor.
			DisableControls(true);

			ToogleToolbar(true);
			Refrescar();
		}

		private void ToogleToolbar(bool state)
		{
			toolNew.Enabled = state;
			toolEdit.Enabled = state;
			toolSave.Enabled = !state;
			toolCancel.Enabled = !state;
			toolRefresh.Enabled = state;
		}

		private void DisableControls(bool state)
		{
			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is TextBox || ctrl is ComboBox || ctrl is NumericUpDown)
					ctrl.Enabled = !state;
			}
		}

		protected virtual void Nuevo()
		{
			DisableControls(false);
			ToogleToolbar(false);
		}

		protected virtual void Editar()
		{
			ToogleToolbar(false);
			DisableControls(false);
		}

		protected virtual void Grabar()
		{
			ToogleToolbar(true);
			DisableControls(true);
		}

		protected virtual void Cancelar()
		{
			ToogleToolbar(true);
			DisableControls(true);
		}

		protected virtual void Refrescar()
		{

		}
	}
}
