using System;
using System.Linq;
using System.Collections.Generic;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.IndexOf(key) != -1)
            {
                text = text.Remove(text.IndexOf(key), key.Length);
            }
            Console.WriteLine(text);
        }
    }
}