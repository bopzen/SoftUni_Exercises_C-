using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Revision")
                {
                    break;
                }

                string[] input = command.Split(", ");
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);
            }

            shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var (shop, products) in shops)
            {
                Console.WriteLine($"{shop}->");
                foreach (var (name, price) in products)
                {
                    Console.WriteLine($"Product: {name}, Price: {price}");
                }
            }
        }
    }
}
