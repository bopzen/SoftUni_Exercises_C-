using System;
using System.Linq;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var number in numbers)
            {
                int roundedNumber = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {roundedNumber}");
            }

        }
    }
}