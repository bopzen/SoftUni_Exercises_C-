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
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Item newItem = new Item(itemName, itemPrice);
                Box newBox = new Box(serialNumber, newItem, itemQuantity);
                boxes.Add(newBox);
            }

            foreach (Box box in boxes.OrderByDescending(x => x.PriceBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }

        }
    }

    class Item
    {
        public Item(string name, decimal price) 
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.Quantity = quantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox 
        { 
            get
            {
                return Quantity * Item.Price;
            }
        }

    }

}