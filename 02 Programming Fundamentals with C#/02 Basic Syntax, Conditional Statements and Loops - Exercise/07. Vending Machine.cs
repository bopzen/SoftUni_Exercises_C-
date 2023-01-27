using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Start")
                {
                    break;
                }

                double coin = double.Parse(command);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin ==2)
                {
                    balance += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                double price = 0;

                if (command == "Nuts")
                {
                    price = 2.0;
                }
                else if (command == "Water")
                {
                    price = 0.7;
                }
                else if (command == "Crisps")
                {
                    price = 1.5;
                }
                else if (command == "Soda")
                {
                    price = 0.8;
                }
                else if (command == "Coke")
                {
                    price = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (price > balance)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    balance -= price;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
            }

            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}