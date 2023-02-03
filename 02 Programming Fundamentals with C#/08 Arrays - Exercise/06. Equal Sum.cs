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
            bool isMatch = false;
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                if (i > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += array[j];
                    }
                }
                if (i < array.Length - 1)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        rightSum += array[j];
                    }
                }
                if (rightSum == leftSum)
                {
                    isMatch = true;
                    Console.WriteLine(i);
                }
            }
            if (!isMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
