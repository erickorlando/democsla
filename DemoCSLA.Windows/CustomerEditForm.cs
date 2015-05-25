using Csla;
using DemoCSLA.Negocio.Editables;
using DemoCSLA.Negocio.ReadOnly;
using System;
using System.Windows.Forms;

namespace DemoCSLA.Windows
{
	public partial class CustomerEditForm : Form
	{

		private CustomerEdit customer;

		public CustomerEditForm()
		{
			InitializeComponent();
		}

		private void CustomerEditForm_Load(object sender, EventArgs e)
		{
			// Cargamos todos los registros en la Grilla.

			Listar();
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

		private void btnNew_Click(object sender, EventArgs e)
		{
			customer = CustomerEdit.NewCustomerEdit();

			customerEditBindingSource.DataSource = customer;
			customerEditBindingSource.ResetBindings(false);

			nameTextBox.Focus();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			customerEditBindingSource.RaiseListChangedEvents = false;

			customerEditBindingSource.EndEdit();

			try
			{
				Cursor = Cursors.WaitCursor;

				customer.Save();

				Listar();
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

		private void btnEdit_Click(object sender, EventArgs e)
		{
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

		private void btnCancel_Click(object sender, EventArgs e)
		{
			customerEditBindingSource.CancelEdit();
			customerEditBindingSource.ResetBindings(false);
		}
	}
}
