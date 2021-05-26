using CommonBase.Extensions;
using SnQSimpleOrder.Contracts.Persistence.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQSimpleOrder.Logic.Entities.Persistence.App
{
	class Order : VersionEntity, SnQSimpleOrder.Contracts.Persistence.App.IOrder
	{
		public uint Amount { get; set; }
		public string ItemNumber { get; set; }
		public double Price { get; set; }
		public double Discount { get; set; }
		public double PriceGross => Amount * Price;
		public double PriceEnd => PriceGross * (1 - Discount);

		public void CopyProperties(IOrder other)
		{
			other.CheckArgument(nameof(other));

			Id = other.Id;
			RowVersion = other.RowVersion;
			Amount = other.Amount;
			ItemNumber = other.ItemNumber;
			Price = other.Price;
			Discount = other.Discount;
		}
	}
}
