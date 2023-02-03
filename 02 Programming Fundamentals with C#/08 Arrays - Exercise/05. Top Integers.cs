using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                bool isTop = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] >= array[i])
                    {
                        isTop = false;
                    }
                }
                if (isTop)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}