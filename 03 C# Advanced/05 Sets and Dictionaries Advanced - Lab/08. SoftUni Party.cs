using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "PARTY")
                {
                    break;
                }
                guests.Add(command);
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                if (guests.Contains(command))
                {
                    guests.Remove(command);
                }
            }
            Console.WriteLine(guests.Count);
            foreach (var item in guests)
            {
                char[] symbols = item.ToCharArray();
                if (char.IsDigit(symbols[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in guests)
            {
                char[] symbols = item.ToCharArray();
                if (!char.IsDigit(symbols[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
