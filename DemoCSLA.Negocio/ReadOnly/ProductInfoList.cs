using Csla;
using Csla.Data.EF6;
using DemoCSLA.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSLA.Negocio.ReadOnly
{
	[Serializable]
	public class ProductInfoList : ReadOnlyListBase<ProductInfoList, ProductInfo>
	{

		private ProductInfoList()
		{

		}

		public static ProductInfoList GetProductInfoList()
		{
			return DataPortal.Fetch<ProductInfoList>();
		}

		private void DataPortal_Fetch()
		{
			RaiseListChangedEvents = false;
			IsReadOnly = false;

			using (var ctx = DbContextManager<DemoCSLAContainer>.GetManager())
			{
				foreach (var item in Producto.GetAllProductos())
				{
					this.Add(ProductInfo.GetProductInfo(item));
				}
			}

			IsReadOnly = true;
			RaiseListChangedEvents = true;
		}

	}
}
