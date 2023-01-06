using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(kids);
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            
            while (queue.Count > 1)
            {
                string currentKid = queue.Dequeue();
                counter++;
                if (counter == n)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    counter = 0;
                }
                else
                {
                    queue.Enqueue(currentKid);
                }
            }
            Console.WriteLine($"Last is {queue.Peek()}");
            
        }
    }
}