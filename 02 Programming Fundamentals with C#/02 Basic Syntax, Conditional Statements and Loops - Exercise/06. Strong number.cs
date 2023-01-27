using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumFactorials = 0;
            foreach (char digit in number.ToString())
            {
                int factorialDigit = 1;
                string digitString = digit.ToString();
                int digitInt = int.Parse(digitString);
                for (int i = 1; i <= digitInt; i++)
                {
                    factorialDigit *= i;
                }
                sumFactorials += factorialDigit;
            }
            if (number == sumFactorials)
            {
                Console.WriteLine("yes");

            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
