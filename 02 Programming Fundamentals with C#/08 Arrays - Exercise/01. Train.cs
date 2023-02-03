using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Transactions;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagon = new int[n];

            for (int i = 0; i < n; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", wagon));
            Console.WriteLine(wagon.Sum());

        }
    }
}