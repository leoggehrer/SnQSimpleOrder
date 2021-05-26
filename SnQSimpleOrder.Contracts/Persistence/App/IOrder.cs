using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQSimpleOrder.Contracts.Persistence.App
{
	public interface IOrder : IVersionable, ICopyable<IOrder>
	{
		uint Amount { get; set; }
		// 8-stellige Produktnummer
		string ItemNumber { get; set; }
		// Einzelpreis (darf nicht negativ sein)
		double Price { get; set; }
		// Darf nicht negativ sein und groesser 1
		double Discount { get; set; }
		// Dieser kann nicht geaendert werden
		double PriceEnd { get; }
	}
}
