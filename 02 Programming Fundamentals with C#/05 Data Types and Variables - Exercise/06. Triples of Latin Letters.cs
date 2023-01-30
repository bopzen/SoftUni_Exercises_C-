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
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char letter1 = (char) (i + 97);
                        char letter2 = (char) (j + 97);
                        char letter3 = (char) (k + 97);


                        Console.WriteLine(letter1.ToString() + letter2.ToString() + letter3.ToString());
                    }
                }
            }
        }
    }
}