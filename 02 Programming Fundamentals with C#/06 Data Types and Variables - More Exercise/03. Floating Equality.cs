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
            double eps = 0.000001;
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            bool isEqual = false;
            if (Math.Abs(n1-n2) < eps)
            {
                isEqual = true;
            }
            Console.WriteLine(isEqual);

        }
    }
}