using Csla;
using DemoCSLA.Datos;
using System;

namespace DemoCSLA.Negocio.ReadOnly
{
	[Serializable]
	public class CustomerInfo : ReadOnlyBase<CustomerInfo>
	{

		public static readonly PropertyInfo<int> IDProperty = RegisterProperty<int>(c => c.ID);
		public int ID
		{
			get { return GetProperty(IDProperty); }
			private set { LoadProperty(IDProperty, value); }
		}

		public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name);
		public string Name
		{
			get { return GetProperty(NameProperty); }
			private set { LoadProperty(NameProperty, value); }
		}

		public static readonly PropertyInfo<string> RUCProperty = RegisterProperty<string>(c => c.RUC);
		public string RUC
		{
			get { return GetProperty(RUCProperty); }
			private set { LoadProperty(RUCProperty, value); }
		}

		public static readonly PropertyInfo<string> PhoneProperty = RegisterProperty<string>(c => c.Phone);
		public string Phone
		{
			get { return GetProperty(PhoneProperty); }
			private set { LoadProperty(PhoneProperty, value); }
		}

		public static readonly PropertyInfo<string> EmailProperty = RegisterProperty<string>(c => c.Email);
		public string Email
		{
			get { return GetProperty(EmailProperty); }
			private set { LoadProperty(EmailProperty, value); }
		}


		public static CustomerInfo GetCustomerInfo(Cliente customer)
		{
			return DataPortal.Fetch<CustomerInfo>(customer);
		}

		protected void DataPortal_Fetch(Cliente customer)
		{
			ID = customer.ID;
			Name = customer.RazonSocial;
			RUC = customer.RUC;
			Phone = customer.Telefono;
			Email = customer.Correo;
		}

	}
}
