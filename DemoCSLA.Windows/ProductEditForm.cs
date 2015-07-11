using Csla;
using Csla.Rules;
using DemoCSLA.Negocio.Editables;
using DemoCSLA.Negocio.ReadOnly;
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
	public partial class ProductEditForm : PlantillaBaseMantenimiento
	{

		private ProductEdit entidad;

		public ProductEditForm()
		{
			InitializeComponent();
		}

		protected override void Cargar()
		{
			base.Cargar();
		}

		protected override void Nuevo()
		{
			base.Nuevo();
			entidad = ProductEdit.NewProductEdit();
			productEditBindingSource.DataSource = entidad;
			productEditBindingSource.ResetBindings(false);
			codigoTextBox.Focus();
		}

		protected override void Editar()
		{
			try
			{
				base.Editar();
				if (productInfoListBindingSource.Current == null)
					return;

				var seleccionado = productInfoListBindingSource.Current as ProductInfo;
				entidad = ProductEdit.GetProductEdit(seleccionado.ID);

				productEditBindingSource.DataSource = entidad;
				productEditBindingSource.ResetBindings(false);
				codigoTextBox.Focus();

			}
			catch (DataPortalException ex)
			{
				MessageBox.Show(ex.BusinessException.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		protected override void Grabar()
		{
			productEditBindingSource.EndEdit();
			productEditBindingSource.RaiseListChangedEvents = false;

			try
			{
				// Forzamos el foco.
				codigoTextBox.Focus();
				entidad.Save();
				Refrescar();
				base.Grabar();
			}
			catch (ValidationException)
			{
				MessageBox.Show(entidad.BrokenRulesCollection.ToString());
			}
			catch (DataPortalException ex)
			{
				MessageBox.Show(ex.BusinessException.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			productEditBindingSource.RaiseListChangedEvents = true;
		}

		protected override void Cancelar()
		{
			productEditBindingSource.CancelEdit();
			productEditBindingSource.ResetBindings(false);
			base.Cancelar();
		}

		protected override void Refrescar()
		{
			base.Refrescar();
			try
			{
				productInfoListBindingSource.DataSource = ProductInfoList.GetProductInfoList();
				productInfoListBindingSource.ResetBindings(false);

			}
			catch (DataPortalException ex)
			{
				MessageBox.Show(ex.BusinessException.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
