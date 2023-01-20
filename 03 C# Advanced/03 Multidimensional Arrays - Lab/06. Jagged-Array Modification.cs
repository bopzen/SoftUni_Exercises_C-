using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] numbers = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] columns = Console.ReadLine().Split().Select(int.Parse).ToArray();
                numbers[row] = columns;
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                string[] tokens = command.Split();

                string action = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row >= 0 && row < numbers.Length && col >= 0 && col < numbers[row].Length) 
                { 
                    if (action == "Add")
                    {
                        numbers[row][col] += value;
                    }
                    else if (action == "Subtract")
                    {
                        numbers[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            foreach (int[] line in numbers)
            {
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}
