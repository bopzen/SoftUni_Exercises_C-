using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 0;
            Console.WriteLine("Length: ");
            length = double.Parse(Console.ReadLine());
            double width = 0;
            Console.WriteLine("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Heigth: ");
            double height = 0;
            height = double.Parse(Console.ReadLine());
            double volume = 0;
            volume = (length + width + height) / 3;
            Console.WriteLine($"Pyramid Volume: {height:f2}");
        }
    }
}