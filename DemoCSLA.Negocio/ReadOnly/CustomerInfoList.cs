using Csla;
using Csla.Data.EF6;
using DemoCSLA.Datos;
using System;

namespace DemoCSLA.Negocio.ReadOnly
{
	[Serializable]
	public class CustomerInfoList : ReadOnlyListBase<CustomerInfoList, CustomerInfo>
	{

		private CustomerInfoList()
		{

		}

		public static CustomerInfoList GetCustomerList()
		{
			return DataPortal.Fetch<CustomerInfoList>();
		}

		private void DataPortal_Fetch()
		{
			RaiseListChangedEvents = false;
			IsReadOnly = false;
			using (var ctx = DbContextManager<DemoCSLAContainer>.GetManager())
			{
				foreach (var item in Cliente.GetAllClientes())
				{
					this.Add(CustomerInfo.GetCustomerInfo(item));
				}
			}
			IsReadOnly = false;
			RaiseListChangedEvents = true;
		}

	}
}
