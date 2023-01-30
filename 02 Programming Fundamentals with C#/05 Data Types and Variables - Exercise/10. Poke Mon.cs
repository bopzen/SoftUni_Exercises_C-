using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int initialPower = power;
            int targets = 0;

            while (power >= distance)
            {       
                power -= distance;
                targets++;
                double percent = Convert.ToDouble(power) / Convert.ToDouble(initialPower);
                if (percent == 0.5)
                {
                    if (y != 0)
                    {
                        power /= y;
                    }
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(targets);
        }
    }
}