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
            int maxNum = 0;
            int maxSequence = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                int currentSequence = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == currentNum)
                    {
                        currentSequence++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    maxNum= currentNum;
                }
            }
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(maxNum + " ");
            }
        }
    }
}
