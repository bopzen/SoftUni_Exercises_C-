using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                if (input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        string name = queue.Dequeue();
                        Console.WriteLine(name);
                    }
                    continue;
                }
                queue.Enqueue(input);
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}