//@CodeCopy

namespace SnQSimpleOrder.Transfer.Models
{
	public partial class IdentityModel : TransferObject, Contracts.IIdentifiable
	{
		public int Id { get; set; }
	}
}
