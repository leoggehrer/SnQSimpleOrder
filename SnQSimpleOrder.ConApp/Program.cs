using System;
using System.Threading.Tasks;

namespace SnQSimpleOrder.ConApp
{
	partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test SnQSimpleOrder");

            BeforeRun();

            AfterRun();
        }

        static partial void BeforeRun();
        static partial void AfterRun();
    }
}
