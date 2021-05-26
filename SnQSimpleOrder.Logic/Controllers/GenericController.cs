//@CodeCopy
using SnQSimpleOrder.Logic.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnQSimpleOrder.Logic.Controllers
{
	internal abstract partial class GenericController<C, E> : ControllerObject, SnQSimpleOrder.Contracts.Client.IControllerAccess<C>
		where C : SnQSimpleOrder.Contracts.IIdentifiable
		where E : Entities.IdentityEntity, C, new()
	{
		protected GenericController(IContext context) : base(context)
		{
		}

		protected GenericController(ControllerObject other) : base(other)
		{
		}

		public abstract Task<int> CountAsync();

		public abstract Task<int> CountByAsync(string predicate);

		public virtual Task<C> CreateAsync()
		{
			return Task.Factory.StartNew<C>(() => new E());
		}

		public abstract Task DeleteAsync(int id);

		public abstract Task<IEnumerable<C>> GetAllAsync(); 

		public abstract Task<C> GetByIdAsync(int id); 

		public abstract Task<C> InsertAsync(C entity); 

		public abstract Task<IEnumerable<C>> QueryAllAsync(string predicate); 

		public virtual Task<int> SaveChangesAsync()
		{
			return Context.SaveChangesAsync();
		}

		public abstract Task<C> UpdateAsync(C entity);
 	}
}
