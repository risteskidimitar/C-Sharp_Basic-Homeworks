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
            Console.WriteLine($"For distance of {distance}km, {distance * (int)levelOfConsumption / 10} % of the battery has been used.");
        }

        public int Recharge(int minutes)
        {
            int percent = minutes / 10;
            return percent;
        }

        public ElectricCar(string brend, string model, int doors, int maxSped, Consumption consump, EngineType engine, int batterycap, int batteryusage)
        : base(brend, model, doors, maxSped, consump, engine)
        {
            BatteryCapacity = batterycap;
            BatteryUsage = batteryusage;

        }
    }
}
