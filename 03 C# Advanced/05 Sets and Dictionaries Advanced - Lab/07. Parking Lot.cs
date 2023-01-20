using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] input = command.Split(", ");
                string destination = input[0];
                string carNumber = input[1];

                if (destination == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else if (destination == "OUT")
                {
                    parkingLot.Remove(carNumber);
                }
            }
            if (parkingLot.Count > 0)
            {
                foreach (var item in parkingLot)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
