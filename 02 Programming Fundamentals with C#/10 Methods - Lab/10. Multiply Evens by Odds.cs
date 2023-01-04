using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
            
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int checkedNumber = Math.Abs(number);
            int sumEven = 0;
            while (checkedNumber > 0)
            {
                int digit = checkedNumber % 10;
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                checkedNumber /= 10;
            }
            return sumEven;
        }

        static int GetSumOfOddDigits(int number)
        {
            int checkedNumber = Math.Abs(number);
            int sumOdd = 0;
            while (checkedNumber > 0)
            {
                int digit = checkedNumber % 10;
                if (digit % 2 != 0)
                {
                    sumOdd += digit;
                }
                checkedNumber /= 10;
            }
            return sumOdd;
        }
    }

}