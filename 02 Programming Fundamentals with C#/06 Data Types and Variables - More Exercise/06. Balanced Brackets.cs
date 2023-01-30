using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Transactions;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isOpen = false;
            bool isBalanced = false;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                if (line == "(" && !isOpen)
                {
                    isOpen = true;
                    isBalanced = false;
                }
                else if (line == "(" && isOpen)
                {
                    isBalanced = false;
                    break;
                }
                else if (line == ")" && !isOpen)
                {
                    isBalanced = false;
                    break;
                }
                else if (line == ")" && isOpen)
                {
                    isOpen = false;
                    isBalanced = true;
                }
                
            }
            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
