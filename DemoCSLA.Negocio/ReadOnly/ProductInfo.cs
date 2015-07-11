using Csla;
using DemoCSLA.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSLA.Negocio.ReadOnly
{
	[Serializable]
	public class ProductInfo : ReadOnlyBase<ProductInfo>
	{
		public int ID { get; set; }
		public string Codigo { get; set; }
		public string Descripcion { get; set; }
		public decimal PrecioUnitario { get; set; }


		public static ProductInfo GetProductInfo(Producto entidad)
		{
			return DataPortal.Fetch<ProductInfo>(entidad);
		}

		protected void DataPortal_Fetch(ProductInfo entidad)
		{
			ID = entidad.ID;
			Codigo = entidad.Codigo;
			Descripcion = entidad.Descripcion;
			PrecioUnitario = entidad.PrecioUnitario;
		}
	}
}
