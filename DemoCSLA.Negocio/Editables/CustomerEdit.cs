using Csla;
using Csla.Data.EF6;
using DemoCSLA.Datos;
using System;
using System.ComponentModel.DataAnnotations;

namespace DemoCSLA.Negocio.Editables
{
	[Serializable]
	public class CustomerEdit : BusinessBase<CustomerEdit>
	{

		#region Properties
		public static readonly PropertyInfo<int> IDProperty = RegisterProperty<int>(c => c.ID);
		public int ID
		{
			get { return GetProperty(IDProperty); }
			set { SetProperty(IDProperty, value); }
		}

		public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name, "Nombre");
		[Required]
		public string Name
		{
			get { return GetProperty(NameProperty); }
			set { SetProperty(NameProperty, value); }
		}

		public static readonly PropertyInfo<string> RUCProperty = RegisterProperty<string>(c => c.RUC);
		[Required]
		public string RUC
		{
			get { return GetProperty(RUCProperty); }
			set { SetProperty(RUCProperty, value); }
		}

		public static readonly PropertyInfo<string> PhoneProperty = RegisterProperty<string>(c => c.Phone);
		[Required]
		public string Phone
		{
			get { return GetProperty(PhoneProperty); }
			set { SetProperty(PhoneProperty, value); }
		}

		public static readonly PropertyInfo<string> EmailProperty = RegisterProperty<string>(c => c.Email);
		[Required]
		public string Email
		{
			get { return GetProperty(EmailProperty); }
			set { SetProperty(EmailProperty, value); }
		}
		#endregion

		#region Business Rules
		protected override void AddBusinessRules()
		{
			base.AddBusinessRules();
		}
		#endregion

		#region Factory Methods

		public static CustomerEdit NewCustomerEdit()
		{
			return DataPortal.Create<CustomerEdit>();
		}

		public static CustomerEdit GetCustomerEdit(int id)
		{
			return DataPortal.Fetch<CustomerEdit>(id);
		}

		public static void DeleteCustomerEdit(int id)
		{
			DataPortal.Delete<CustomerEdit>(id);
		}
		#endregion

		#region Data Access
		private void DataPortal_Fetch(int id)
		{
			var customer = Cliente.GetClienteByID(id);

			using (BypassPropertyChecks)
			{
				ID = customer.ID;
				Name = customer.RazonSocial;
				RUC = customer.RUC;
				Phone = customer.Telefono;
				Email = customer.Correo;
			}
			BusinessRules.CheckRules();
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Insert()
		{
			using (var ctx = DbContextManager<DemoCSLAContainer>.GetManager())
			{
				var customer = new Cliente();

				DoInsertUpdate(customer);

				ctx.DbContext.ClienteSet.Add(customer);
				ctx.DbContext.SaveChanges();
			}
		}

		private void DoInsertUpdate(Cliente customer)
		{
			using (BypassPropertyChecks)
			{
				customer.ID = ID;
				customer.RazonSocial = Name;
				customer.RUC = RUC;
				customer.Telefono = Phone;
				customer.Correo = Email;
			}
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Update()
		{
			using (var ctx = DbContextManager<DemoCSLAContainer>.GetManager())
			{
				var customer = Cliente.GetClienteByID(ID);

				DoInsertUpdate(customer);

				ctx.DbContext.SaveChanges();
			}
		}

		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(ReadProperty(IDProperty));
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		private void DataPortal_Delete(int id)
		{
			using (var ctx = DbContextManager<DemoCSLAContainer>.GetManager())
			{
				var customer = Cliente.GetClienteByID(id);

				ctx.DbContext.ClienteSet.Remove(customer);
				ctx.DbContext.SaveChanges();
			}

		}
		#endregion

	}
}
