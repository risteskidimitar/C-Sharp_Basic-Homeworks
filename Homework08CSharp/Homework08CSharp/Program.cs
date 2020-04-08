using System;
using Homework08CSharp.Entities;

namespace Homework08CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework Class08");

            Console.WriteLine("class Car");

            var MyNewCar = new Car("Aston Martin", "DBS Superleggera", 3, 260 ,Enums.Consumption.high, Enums.EngineType.petrol);

            MyNewCar.PrintInfo();

            Console.WriteLine("class ElectricCar");

            var tesla = new ElectricCar("Tesla", "Newest", 5, 220 ,Enums.Consumption.economic, Enums.EngineType.electric, 80, 20);


            tesla.PrintInfo();
            tesla.Drive(150);

            Console.WriteLine($"{tesla.Recharge(600)}");
            



            Console.ReadLine();

        }
    }
}
