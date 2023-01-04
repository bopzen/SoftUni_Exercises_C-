using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isValid = false;
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                isValid = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isValid}");
            }

        }
    }
}