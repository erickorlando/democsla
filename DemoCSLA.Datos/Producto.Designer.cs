using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSLA.Datos
{
	public partial class Producto
	{

		public static Producto GetProductoById(int id)
		{
			using (var ctx = new DemoCSLAContainer())
			{
				var product = ctx.ProductoSet.SingleOrDefault(p => p.ID == id);

				if (product != null)
				{
					return product;
				}

				throw new InvalidOperationException("No se encuentra el Producto con el ID especificado");
			}
		}

		public static IEnumerable<Producto> GetAllProductos()
		{
			using (var ctx = new DemoCSLAContainer())
			{
				return ctx.ProductoSet.ToList();
			}
		}

	}
}
