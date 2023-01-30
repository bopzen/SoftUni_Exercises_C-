using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            courses = people / capacity;
            int remaining = people % capacity;
            if (remaining > 0)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}