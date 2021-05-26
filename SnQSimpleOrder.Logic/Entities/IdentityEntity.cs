//@CodeCopy

using CommonBase.Extensions;
using SnQSimpleOrder.Contracts;

namespace SnQSimpleOrder.Logic.Entities
{
	internal abstract partial class IdentityEntity : IIdentifiable
	{
		public int Id { get; set; }
	}
}
