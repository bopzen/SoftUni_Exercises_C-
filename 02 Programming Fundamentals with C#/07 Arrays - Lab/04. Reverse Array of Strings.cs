using System;
using System.Linq;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < array.Length / 2; i++)
            {
                string oldValue = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = oldValue;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}