using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double totalSpent = 0;
            while (true)
            {
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                string command = Console.ReadLine();
                if (command == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
                    break;
                }

                string game = command;
                double price = 0;

                if (game == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (game == "CS: OG")
                {
                    price = 15.99;
                }
                else if (game == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (game == "Honored 2")
                {
                    price = 59.99;
                }
                else if (game == "RoverWatch")
                {
                    price = 29.99;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (balance >= price)
                {
                    Console.WriteLine($"Bought {game}");
                    balance -= price;
                    totalSpent += price;
                }
                else 
                {
                    Console.WriteLine("Too Expensive");
                }

            }
        }
    }
}


