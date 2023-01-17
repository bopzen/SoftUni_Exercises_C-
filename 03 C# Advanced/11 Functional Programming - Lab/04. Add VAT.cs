using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> vat = n => n * 1.2;
            double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(vat).ToArray();
            foreach (double price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}