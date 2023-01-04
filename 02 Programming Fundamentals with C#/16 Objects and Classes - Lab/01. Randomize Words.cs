using System;
using System.Linq;
using System.Collections.Generic;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            Random rnd = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                int j = rnd.Next(text.Length);
                string word = text[i];
                text[i] = text[j];
                text[j] = word;
            }
            Console.WriteLine(string.Join(Environment.NewLine, text));
        }
    }
}