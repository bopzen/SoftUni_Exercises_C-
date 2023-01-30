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
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                message += (char)((int)symbol + key);
            }
            Console.WriteLine(message);
        }
    }
}