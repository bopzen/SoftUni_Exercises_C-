using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stackedText = new Stack<char>();
            string text = Console.ReadLine();
            foreach (char symbol in text)
            {
                stackedText.Push(symbol);
            }
            while (stackedText.Count > 0)
            {
                Console.Write(stackedText.Pop());
            }
        }
    }
}