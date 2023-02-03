using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Transactions;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();
            foreach (var item in secondArray)
            {
                if (firstArray.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}