using Csla;
using Csla.Data.EF6;
using DemoCSLA.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSLA.Negocio.Editables
{
	[Serializable]
	public class ProductEdit : BusinessBase<ProductEdit>
	{
		#region Properties
		public static readonly PropertyInfo<int> IDProperty = RegisterProperty<int>(c => c.ID);
		public int ID
		{
			get { return GetProperty(IDProperty); }
			set { SetProperty(IDProperty, value); }
		}

		public static readonly PropertyInfo<string> CodigoProperty = RegisterProperty<string>(c => c.Codigo, "Código");
		public string Codigo
		{
			get { return GetProperty(CodigoProperty); }
			set { SetProperty(CodigoProperty, value); }
		}

		public static readonly PropertyInfo<string> DescripcionProperty = RegisterProperty<string>(c => c.Descripcion, "Descripción");
		public string Descripcion
		{
			get { return GetProperty(DescripcionProperty); }
			set { SetProperty(DescripcionProperty, value); }
		}

		public static readonly PropertyInfo<decimal> PrecioUnitarioProperty = RegisterProperty<decimal>(c => c.PrecioUnitario, "Precio Unitario");
		public decimal PrecioUnitario
		{
			get { return GetProperty(PrecioUnitarioProperty); }
			set { SetProperty(PrecioUnitarioProperty, value); }
		} 
		#endregion

		#region Business Rules
		protected override void AddBusinessRules()
		{
			base.AddBusinessRules();
		} 
		#endregion

		#region Factory Methods
		public static ProductEdit NewProductEdit()
		{
			return DataPortal.Create<ProductEdit>();
		}

		public static ProductEdit GetProductEdit(int ID)
		{
			return DataPortal.Fetch<ProductEdit>(ID);
		}

		public static void DeleteProductEdit(int ID)
		{
			DataPortal.Delete<ProductEdit>(ID);
		} 
		#endregion

		#region Data Access
		private void DataPortal_Fetch(int id)
		{
			var product = Producto.GetProductoById(id);

			using (BypassPropertyChecks)
			{
				ID = product.ID;
				Codigo = product.Codigo;
				Descripcion = product.Descripcion;
				PrecioUnitario = product.PrecioUnitario;
			}
			BusinessRules.CheckRules();
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Insert()
		{
			using (var ctx = DbContextManager<DemoCSLAContainer>.GetManager())
			{
				var product = new Producto();

				DoInsertUpdate(product);

				ctx.DbContext.ProductoSet.Add(product);
				ctx.DbContext.SaveChanges();
			}
		}

		private void DoInsertUpdate(Producto product)
		{
			using (BypassPropertyChecks)
			{
				product.ID = ID;
				product.Codigo = Codigo;
				product.Descripcion = Descripcion;
				product.PrecioUnitario = PrecioUnitario;
			}
		}

		[Transactional(TransactionalTypes.TransactionScope)]
		protected override void DataPortal_Update()
		{
			using (var ctx = DbContextManager<DemoCSLAContainer>.GetManager())
			{
				var product = ctx.DbContext.ProductoSet.SingleOrDefault(p => p.ID == ID);

				DoInsertUpdate(product);

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
				var product = Producto.GetProductoById(id);

				ctx.DbContext.ProductoSet.Remove(product);
				ctx.DbContext.SaveChanges();
			}
		} 
		#endregion

	}
}
