using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> numbersCount = new Dictionary<double, int>();

            foreach (double number in numbers)
            {
                if (numbersCount.ContainsKey(number))
                {
                    numbersCount[number]++;
                }
                else
                {
                    numbersCount.Add(number, 1);
                }
            }
            foreach (var item in numbersCount)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}