using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);

            while (true)
            {
                string command = Console.ReadLine().ToLower();
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];
                if (action == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (action == "remove")
                {
                    int count = int.Parse(tokens[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }

                }
            }
            int sum = 0;
            foreach (int i in stack)
            {
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");

        }
    }
}