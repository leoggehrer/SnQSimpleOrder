//@CodeCopy

namespace SnQSimpleOrder.Contracts
{
	public partial interface ICopyable<T>
	{
		void CopyProperties(T other);
	}
}
