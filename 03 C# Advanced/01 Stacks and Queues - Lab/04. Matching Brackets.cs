using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = stack.Pop();
                    string result = expression.Substring(startIndex, i - startIndex + 1);

                    Console.WriteLine(result);
                }
            }
        }
    }
}