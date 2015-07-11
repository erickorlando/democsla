using Csla;
using DemoCSLA.Negocio.Editables;
using DemoCSLA.Negocio.ReadOnly;
using System;
using System.Windows.Forms;

namespace DemoCSLA.Windows
{
	public partial class CustomerEditForm : PlantillaBaseMantenimiento
	{

		private CustomerEdit customer;

		public CustomerEditForm()
		{
			InitializeComponent();
		}

		protected override void Cargar()
		{
			// Cargamos todos los registros en la Grilla.

			Listar();
			base.Cargar();
		}

		private void Listar()
		{
			try
			{
				Cursor = Cursors.WaitCursor;

				customerInfoListBindingSource.DataSource = CustomerInfoList.GetCustomerList();
				customerInfoListBindingSource.ResetBindings(false);
			}
			catch (DataPortalException ex)
			{
				MessageBox.Show(ex.BusinessException.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		protected override void Nuevo()
		{
			base.Nuevo();
			customer = CustomerEdit.NewCustomerEdit();

			customerEditBindingSource.DataSource = customer;
			customerEditBindingSource.ResetBindings(false);

			nameTextBox.Focus();
		}

		protected override void Editar()
		{
			base.Editar();
			// Obtenemos el registro seleccionado y lo enviamos a las cajas de texto.

			try
			{
				if (customerInfoListBindingSource.Current == null) return;

				var seleccionado = customerInfoListBindingSource.Current as CustomerInfo;

				// Cargamos el registro en base al ID.
				customer = CustomerEdit.GetCustomerEdit(seleccionado.ID);

				customerEditBindingSource.DataSource = customer;
				customerEditBindingSource.ResetBindings(false);
				nameTextBox.Focus();

			}
			catch (DataPortalException ex)
			{
				MessageBox.Show(ex.BusinessException.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		protected override void Grabar()
		{
			customerEditBindingSource.RaiseListChangedEvents = false;

			customerEditBindingSource.EndEdit();

			try
			{
				Cursor = Cursors.WaitCursor;

				customer.Save();

				Listar();
				base.Grabar();
			}
			catch (DataPortalException ex)
			{
				MessageBox.Show(ex.BusinessException.Message, "Grabar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Csla.Rules.ValidationException)
			{
				MessageBox.Show(customer.BrokenRulesCollection.ToString(), "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			finally
			{
				Cursor = Cursors.Default;
			}

			customerEditBindingSource.RaiseListChangedEvents = true;
		}

		protected override void Cancelar()
		{
			base.Cancelar();
			customerEditBindingSource.CancelEdit();
			customerEditBindingSource.ResetBindings(false);
		}

		protected override void Refrescar()
		{
			base.Refrescar();
			Listar();
		}

	}
}
