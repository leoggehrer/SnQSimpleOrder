//@CodeCopy

namespace SnQSimpleOrder.Contracts
{
	public partial interface IVersionable : IIdentifiable
	{
		byte[] RowVersion { get; }
	}
}
