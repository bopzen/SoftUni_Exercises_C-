using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age >= 0 && age <= 18)
            {
                if (typeOfDay == "weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 15;
                }
                else if (typeOfDay == "holiday")
                {
                    price = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (typeOfDay == "weekday")
                {
                    price = 18;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 20;
                }
                else if (typeOfDay == "holiday")
                {
                    price = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (typeOfDay == "weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 15;
                }
                else if (typeOfDay == "holiday")
                {
                    price = 10;
                }
            }
            
            if (price != 0)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}