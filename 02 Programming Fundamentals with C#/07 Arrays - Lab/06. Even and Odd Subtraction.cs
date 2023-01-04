using System;
using System.Linq;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int summEven = 0;
            int sumOdd = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    summEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }
            Console.WriteLine(summEven - sumOdd);
            
        }
    }
}