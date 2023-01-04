using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int pounds = int.Parse(Console.ReadLine());
            double dollars = pounds * 1.31;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}