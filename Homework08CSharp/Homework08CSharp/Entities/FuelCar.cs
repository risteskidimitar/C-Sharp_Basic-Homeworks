using System;
using System.Collections.Generic;
using System.Text;
using Homework08CSharp.Enums;


namespace Homework08CSharp.Entities
{
    class FuelCar : Car
    {
        public int FuelCapacity;
        public int CurrentFuel;

        public void Drive(int distance)
        {
            var formula1 = distance * (int)levelOfConsumption / 10;

            if (CurrentFuel - formula1 < 0)
            {
                Console.WriteLine($"You don't have enough fuel, " +
                    $"maximum distance you can passed is: {CurrentFuel / (int)levelOfConsumption * 10} km");
            }
            else
            {
                CurrentFuel -= formula1;
                Console.WriteLine($"For passed distance of {distance} km, fuel in tank is now {CurrentFuel} l ");
            }
        }

        public void Refuel(int fuel)
        {
    
            if (fuel > FuelCapacity - CurrentFuel)
            {
                Console.WriteLine($"Can't add more than {FuelCapacity - CurrentFuel} l fuel");
            }
            else
            {
                CurrentFuel += fuel;
                Console.WriteLine($"You have now {CurrentFuel} l of {TypeOfEngine}");
            }
        }

        public FuelCar()
        {
        }

    }
}
