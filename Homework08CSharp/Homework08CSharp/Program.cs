using System;
using Homework08CSharp.Entities;

namespace Homework08CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Electric Car");

            var tesla = new ElectricCar("Tesla", "Newest", 5, 220, Enums.Consumption.economic, Enums.EngineType.electric, 100, 80);


            tesla.PrintInfo();
            tesla.Drive(150);
            tesla.Recharge(300);

            Console.WriteLine();


            Console.WriteLine("Fuel Car");

            var astonMartin = new FuelCar()
            {
                Brand = "Aston Martin",
                Model = "DBS Superleggera",
                Doors = 3,
                TopSpeed = 280,
                levelOfConsumption = Enums.Consumption.high,
                TypeOfEngine = Enums.EngineType.petrol,
                FuelCapacity = 80,
                CurrentFuel = 60,

            };

            astonMartin.PrintInfo();
            astonMartin.Drive(1500);
            astonMartin.Refuel(40);

            Console.ReadLine();

        }
    }
}
