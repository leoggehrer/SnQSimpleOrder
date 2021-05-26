using SnQSimpleOrder.Contracts.Persistence.App;
using SnQSimpleOrder.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQSimpleOrder.Logic.Controllers.Persistence.App
{
	class OrderController : GenericPersistenceController<IOrder, Entities.Persistence.App.Order>
	{
		public OrderController(IContext context) : base(context)
		{
		}

		public OrderController(ControllerObject other) : base(other)
		{
		}

		private void CheckOrder(IOrder order)
		{
			if (order.ItemNumber == null)
				throw new Exception("ItemNumber darf nicht null sein!");
			else if (order.ItemNumber.Length < 8)
				throw new Exception("ItemNumber muss 8 Zeichen sein!");
		}
		public override Task<IOrder> InsertAsync(IOrder entity)
		{
			CheckOrder(entity);

			return base.InsertAsync(entity);
		}
	}
}
