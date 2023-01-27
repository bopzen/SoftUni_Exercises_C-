using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int mainDigit = int.Parse(input[0].ToString());
                if (mainDigit == 0)
                {
                    message += " ";
                    continue;
                }
                int length = input.Length;
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = (offset + length - 1);
                message += Convert.ToChar(letterIndex + 97);
            }
            Console.WriteLine(message); 
        }
    }
}