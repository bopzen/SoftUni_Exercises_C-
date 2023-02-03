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
            int sequenceLength = int.Parse(Console.ReadLine());
            int bestSequenceStartIndex = 0;
            int bestSequenceCountOnes = 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 1;
            int[] bestSequence = new int[sequenceLength];

            int sequenceCount = 1;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] currentSequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int startIndex = 0;
                int countOnes = 0;
                for (int i = 0; i < currentSequence.Length; i++)
                {
                    if (currentSequence[i] == 1)
                    {
                        int counter = 0;
                        for (int j = i + 1; j < currentSequence.Length; j++)
                        {
                            if (currentSequence[j] == 1)
                            {
                                counter++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (counter > countOnes)
                        {
                            countOnes = counter;
                            startIndex = i;
                        }
                    }              
                }
                if (countOnes > bestSequenceCountOnes)
                {
                    bestSequenceCountOnes = countOnes;
                    bestSequenceStartIndex = startIndex;
                    bestSequenceSum = currentSequence.Sum();
                    bestSequenceIndex = sequenceCount;
                    bestSequence = currentSequence;
                }
                else if (countOnes == bestSequenceCountOnes)
                {
                    if (startIndex < bestSequenceStartIndex)
                    {
                        bestSequenceCountOnes = countOnes;
                        bestSequenceStartIndex = startIndex;
                        bestSequenceSum = currentSequence.Sum();
                        bestSequenceIndex = sequenceCount;
                        bestSequence = currentSequence;
                    }
                    else if (startIndex == bestSequenceStartIndex)
                    {
                        if (currentSequence.Sum() > bestSequenceSum)
                        {
                            bestSequenceCountOnes = countOnes;
                            bestSequenceStartIndex = startIndex;
                            bestSequenceSum = currentSequence.Sum();
                            bestSequenceIndex = sequenceCount;
                            bestSequence = currentSequence;
                        }
                    }
                }
                sequenceCount++;
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
