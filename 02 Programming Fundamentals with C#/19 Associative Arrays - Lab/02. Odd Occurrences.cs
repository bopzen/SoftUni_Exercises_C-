using System;
using System.Linq;
using System.Collections.Generic;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts= new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (counts.ContainsKey(word.ToLower()))
                {
                    counts[word.ToLower()]++;
                }
                else
                {
                    counts[word.ToLower()] = 1;
                }
            }
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}   