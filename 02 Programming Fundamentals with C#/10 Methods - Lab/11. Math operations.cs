using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(number1, oper, number2));
            
        }

        static double Calculate(int a, string oper, int b)
        {
            double result = 0;
                switch (oper)
                {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b; 
                    break;
                case "/":
                    result = a / b;
                    break;
                }
            return result;
        }
    }

}