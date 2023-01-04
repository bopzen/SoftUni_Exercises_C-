using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Xml.Schema;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog(new List<Car>(), new List<Truck>());
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split("/");

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];

                if (type == "Car")
                {
                    int horsePower = int.Parse(tokens[3]);
                    Car newCar = new Car(brand, model, horsePower);
                    catalog.Cars.Add(newCar);
                }
                else if (type == "Truck")
                {
                    int weight = int.Parse(tokens[3]);
                    Truck newTruck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(newTruck);
                }
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public Truck(string brand, string model, int weight) 
        {
            this.Brand = brand;
            this.Model= model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower) 
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            this.Cars = cars;
            this.Trucks = trucks;
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

}