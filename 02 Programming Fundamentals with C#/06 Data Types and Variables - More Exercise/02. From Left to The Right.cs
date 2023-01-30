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
            for (int i = 0; i < n; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long number = 0;
                long sum = 0;
                if (input[0] > input[1])
                {
                    number = input[0];
                }
                else
                {
                    number = input[1];
                }
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}