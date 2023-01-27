using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsaberTotalPrice = Math.Ceiling(studentsCount * 1.1) * lightsaberPrice;
            double robeTotalPrice = studentsCount * robePrice;
            double beltTotalPrice = (studentsCount - studentsCount / 6) * beltPrice;
            double totalPrice = lightsaberTotalPrice + robeTotalPrice + beltTotalPrice;
            
            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice - money):f2}lv more.");
            }
            
        }
    }
}
