//@CodeCopy
using CommonBase.Extensions;
using SnQSimpleOrder.Contracts.Persistence.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientContracts = SnQSimpleOrder.Contracts.Client;

namespace SnQSimpleOrder.Logic
{
	public static partial class Factory
	{
		private static Contracts.IContext CreateContext()
		{
			return new DataContext.ProjectDbContext();
		}
		public static ClientContracts.IControllerAccess<C> Create<C>()
			where C : SnQSimpleOrder.Contracts.IIdentifiable
		{
			ClientContracts.IControllerAccess<C> result = null;

//			CreateController<C>(CreateContext(), ref result);
			if (typeof(C) == typeof(IOrder))
			{
				result = new Controllers.Persistence.App.OrderController(CreateContext()) as ClientContracts.IControllerAccess<C>;
			}
			return result;
		}
		static partial void CreateController<C>(Contracts.IContext context, ref ClientContracts.IControllerAccess<C> controller) 
			where C : SnQSimpleOrder.Contracts.IIdentifiable;
		public static ClientContracts.IControllerAccess<C> Create<C>(object controller)
			where C : SnQSimpleOrder.Contracts.IIdentifiable
		{
			var controllerObject = controller as Controllers.ControllerObject;

			controllerObject.CheckArgument(nameof(controller));

			ClientContracts.IControllerAccess<C> result = null;

			//			CreateController<C>(controllerObject, ref result);
			if (typeof(C) == typeof(IOrder))
			{
				result = new Controllers.Persistence.App.OrderController(controllerObject) as ClientContracts.IControllerAccess<C>;
			}

			return result;
		}
		static partial void CreateController<C>(Controllers.ControllerObject controllerObject, ref ClientContracts.IControllerAccess<C> controller)
			where C : SnQSimpleOrder.Contracts.IIdentifiable;
	}
}
