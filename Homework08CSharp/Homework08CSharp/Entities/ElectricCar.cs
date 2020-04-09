using System;
using System.Collections.Generic;
using System.Text;
using Homework08CSharp.Enums;

namespace Homework08CSharp.Entities
{
    class ElectricCar : Car
    {
        private int BatteryCapacity;
        private int BatteryUsage;

        public void Drive(int distance)
        {
            var formula1 = distance * (int)levelOfConsumption / 10;

            if (BatteryUsage - formula1 < 0)
            {
                Console.WriteLine($"You don't have enough battery, " +
                    $"maximum distance you can passed is: {BatteryUsage/(int)levelOfConsumption * 10} km");
            }
            else
            {
                BatteryUsage -= formula1;
                Console.WriteLine($"For passed distance of {distance} km, available battery usage is now {BatteryUsage} % ");
            }
        }

        public void Recharge(int minutes)
        {
            var formula2 = minutes / 10;
            if (formula2 > BatteryCapacity - BatteryUsage)
            {
                Console.WriteLine($"Can't charge longer that {(BatteryCapacity - BatteryUsage) * 10} minutes");
            }
            else
            {
                BatteryUsage += formula2;
                Console.WriteLine($"You have charged {formula2} %, available battery usage is now {BatteryUsage} % ");
            }
        }

        public ElectricCar(string brend, string model, int doors, int maxSped, Consumption consump, EngineType engine, int batterycap, int batteryusage)
        : base(brend, model, doors, maxSped, consump, engine)
        {
            BatteryCapacity = batterycap;
            BatteryUsage = batteryusage;
        }
    }
}
