using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] initialIndexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            for (int i = 0; i < initialIndexes.Length; i++)
            {
                if (initialIndexes[i] >= 0 && initialIndexes[i] < field.Length)
                {
                    field[initialIndexes[i]] = 1;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split().ToArray();
                int position = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLength = int.Parse(tokens[2]);

                if (position >= 0 && position < field.Length && field[position] == 1)
                {
                    field[position] = 0;
                    if (direction == "left")
                    {
                        flyLength = -flyLength;
                    }

                    while (true)
                    {
                        if (position + flyLength >= field.Length || position + flyLength < 0)
                        {
                            break;
                        }

                        if (field[position + flyLength] == 0)
                        {
                            field[position + flyLength] = 1;
                            break;
                        }

                        flyLength += flyLength;

                    }
                }
            }
            Console.WriteLine(String.Join(' ', field));
        }
    }
}