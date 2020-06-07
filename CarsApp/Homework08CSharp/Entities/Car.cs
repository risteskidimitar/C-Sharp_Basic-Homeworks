using Homework08CSharp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Homework08CSharp.Enums;

namespace Homework08CSharp.Entities
{
    class Car
    {
        private int codeID = CodeGenerator.RandomCodeGnerator();
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }

        public int TopSpeed;
        public Consumption levelOfConsumption { get; set; }
        public EngineType TypeOfEngine { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Car ID:{codeID}, Brand of the car is {Brand} of model: {Model} with {Doors} doors, \n" +
                $"Level of consumption: {levelOfConsumption}, {TypeOfEngine} type of engine and top speed at {TopSpeed}km/h ");
        }

        public Car(string brend, string model, int doors, int maxSped ,Consumption consump, EngineType engine)
        {
            Brand = brend;
            Model = model;
            Doors = doors;
            TopSpeed = maxSped;
            levelOfConsumption = consump;
            TypeOfEngine = engine;
        }

        public Car()
        {

        }

    }
}
