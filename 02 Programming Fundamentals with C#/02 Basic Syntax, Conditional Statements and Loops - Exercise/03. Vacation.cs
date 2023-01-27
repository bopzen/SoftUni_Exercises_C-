using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string weekDay = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            if (groupType == "Students")
            {
                if (weekDay == "Friday")
                {
                    price = 8.45;
                }
                else if (weekDay == "Saturday")
                {
                    price = 9.80;
                }
                else if (weekDay == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (weekDay == "Friday")
                {
                    price = 10.90;
                }
                else if (weekDay == "Saturday")
                {
                    price = 15.60;
                }
                else if (weekDay == "Sunday")
                {
                    price = 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (weekDay == "Friday")
                {
                    price = 15;
                }
                else if (weekDay == "Saturday")
                {
                    price = 20;
                }
                else if (weekDay == "Sunday")
                {
                    price = 22.50;
                }
            }

            totalPrice = price * countPeople;
            if (groupType == "Students" && countPeople >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            if (groupType == "Business" && countPeople >= 100)
            {
                totalPrice -= 10 * price;
            }
            if (groupType == "Regular" && countPeople >=10 && countPeople <= 20)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}




