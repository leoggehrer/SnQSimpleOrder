//@CodeCopy

using SnQSimpleOrder.Contracts;

namespace SnQSimpleOrder.Logic.Entities
{
	internal abstract partial class VersionEntity : IdentityEntity, IVersionable
	{
		public byte[] RowVersion { get; set; }
	}
}
