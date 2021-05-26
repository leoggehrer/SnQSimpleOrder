using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnQSimpleOrder.Contracts.Persistence.App;
using System;
using System.Threading.Tasks;

namespace SnQSimpleOrder.LogicUnitTest
{
	[TestClass]
	public class OrderUnitTest
	{
		/// <summary>
		/// Testfall: Einfuegen einer Order ohne ItemNummer.
		/// Expected: Eine Ausnamhme vom Type Exception
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public async Task Create_NoItemNumber_ThrowsException()
		{
			var ctrl = Logic.Factory.Create<IOrder>();
			var entity = await ctrl.CreateAsync();

			entity.Amount = 1;
			entity.ItemNumber = null;
			entity.Price = 100;
			entity.Discount = 0.05;
			entity = await ctrl.InsertAsync(entity);
			await ctrl.SaveChangesAsync();
		}
		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public async Task Create_ToShortItemNumber_ThrowsException()
		{
			var ctrl = Logic.Factory.Create<IOrder>();
			var entity = await ctrl.CreateAsync();

			entity.Amount = 1;
			entity.ItemNumber = "123";
			entity.Price = 100;
			entity.Discount = 0.05;
			entity = await ctrl.InsertAsync(entity);
			await ctrl.SaveChangesAsync();

		}

		[TestMethod]
		public void Create_ItemNumber_OrderWithReflectItemNumber()
		{

		}
	}
}
