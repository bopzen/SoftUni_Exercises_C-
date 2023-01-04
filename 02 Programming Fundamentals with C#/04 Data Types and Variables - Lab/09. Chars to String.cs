using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
                for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                result += symbol;
            }
            Console.WriteLine(result);
        }
    }

}