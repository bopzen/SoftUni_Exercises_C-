using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int attempts = 0;

            while (true) 
            {
                string password = Console.ReadLine();
                string reversedPassword = new string(password.ToCharArray().Reverse().ToArray());
                if (username == reversedPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                attempts++;
                if (attempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}