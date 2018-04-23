using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] penceArray = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
            int amountOfPennyForExchange = 200;
            PenceWorker penceWorker = new PenceWorker(amountOfPennyForExchange, penceArray);
            Console.WriteLine("Combinations of exchange: " + penceWorker.findCombinationsOfExchange());
            Console.ReadKey();
        }
    }
}
