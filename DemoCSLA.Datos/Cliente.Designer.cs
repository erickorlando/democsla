using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoCSLA.Datos
{
	public partial class Cliente
	{

		public static Cliente GetClienteByID(int ID)
		{
			using (var ctx = new DemoCSLAContainer())
			{
				var customer = ctx.ClienteSet.SingleOrDefault(c => c.ID == ID);

				if (customer != null)
					return customer;

				throw new InvalidOperationException("No se encuentra el Cliente con el ID especificado");
			}
		}

		public static IEnumerable<Cliente> GetAllClientes()
		{

			using (var ctx = new DemoCSLAContainer())
			{
				return ctx.ClienteSet.ToList();
			}

		}

	}
}
