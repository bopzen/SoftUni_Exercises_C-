using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= n ; i++)
            {
                total += 2 * i - 1;
                Console.WriteLine(2 * i - 1);
          
            }
            Console.WriteLine($"Sum: {total}");
        }
    }
}