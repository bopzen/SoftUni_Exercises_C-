using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int extractedSpice = 0;
            int days = 0;
            while (yield >= 100)
            {
                days++;
                extractedSpice += yield;
                extractedSpice -= 26;
                yield -= 10;
            }

            extractedSpice -= Math.Min(26, extractedSpice);
            Console.WriteLine(days);
            Console.WriteLine(extractedSpice);
        }
    }
}