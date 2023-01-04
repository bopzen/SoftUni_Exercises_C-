using System;
using System.Linq;
using System.Collections.Generic;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers1 = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> numbers2 = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();

            int smallerListLength = Math.Min(numbers1.Count, numbers2.Count);
            int biggerListLength = Math.Max(numbers1.Count, numbers2.Count);
            for (int i = 0; i < biggerListLength; i++)
            {
                if (numbers1.Count > 0)
                {
                    result.Add(numbers1[0]);
                    numbers1.RemoveAt(0);
                }

                if (numbers2.Count > 0)
                {
                    result.Add(numbers2[0]);
                    numbers2.RemoveAt(0);
                }
            }
            Console.WriteLine(string.Join(" ", result));
            
        }
    }
}   