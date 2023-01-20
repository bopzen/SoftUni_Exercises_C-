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
            long[][] triangle = new long[rows][];

            for (int row = 0;  row < rows; row++)
            {
                triangle[row] = new long[row + 1];
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    if (row == 0)
                    {
                        triangle[row][col] = 1;
                        continue;
                    }

                    long currentValue = 0;

                    if (row > 0 && col > 0)
                    {
                        currentValue += triangle[row - 1][col - 1];
                    }

                    if (triangle[row].Length - 1 > col)
                    {
                        currentValue += triangle[row - 1][col];
                    }

                    triangle[row][col] = currentValue;
                }
            }

            foreach (long[] line in triangle)
            {
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}
