using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            const int CAPACITY = 255;
            int capacityLeft = CAPACITY;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine()) ;
                if (liters <= capacityLeft)
                {
                    capacityLeft -= liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(CAPACITY - capacityLeft);
        }
    }
}