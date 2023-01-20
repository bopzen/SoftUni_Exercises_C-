using System;


namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> listTires = new List<Tire[]>();
            

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "No more tires")
                {
                    break;
                }
                string[] commands = command.Split();
                Tire[] currTires = new Tire[4]
                {
                 new Tire(int.Parse(commands[0]), double.Parse(commands[1])),
                 new Tire(int.Parse(commands[2]), double.Parse(commands[3])),
                 new Tire(int.Parse(commands[4]), double.Parse(commands[5])),
                 new Tire(int.Parse(commands[6]), double.Parse(commands[7]))
                };
                listTires.Add(currTires);
            }

            List<Engine> listEngines = new List<Engine>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Engines done")
                {
                    break;
                }
                string[] commands = command.Split();
                int horsePower = int.Parse(commands[0]);
                double cubicCapacity = double.Parse(commands[1]);
                Engine newEngine = new Engine(horsePower, cubicCapacity);
                listEngines.Add(newEngine);
            }

            List<Car> cars = new List<Car>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Show special")
                {
                    break;
                }
                string[] commands = command.Split();
                string make = commands[0];
                string model = commands[1];
                int year = int.Parse(commands[2]);
                double fuelQuantity = double.Parse(commands[3]);
                double fuelConsumption = double.Parse(commands[4]);
                int engineIndex = int.Parse(commands[5]);
                int tireIndex = int.Parse(commands[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, listEngines[engineIndex], listTires[tireIndex]);
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                double totalPressure = 0;
                foreach (Tire Tire in car.Tires) 
                {
                    totalPressure += Tire.Pressure;
                }
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && totalPressure >= 9 && totalPressure <= 10)
                {
                    car.Drive(20);

                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }

        }
    }
}