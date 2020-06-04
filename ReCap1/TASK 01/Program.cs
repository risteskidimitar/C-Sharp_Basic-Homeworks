using System;
using System.Collections.Generic;
using System.Linq;

namespace TASK_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>();


            while (true)
            {
                Console.WriteLine("Please enter a name, or x");
                string names = Console.ReadLine().ToLower();
                if (names == "x") break;
                namesList.Add(names);
            }

            Console.WriteLine("Now enter a text");

            string text = Console.ReadLine().ToLower();

            string[] splitedText = text.Split(" ").ToArray();


            foreach (var name in namesList)
            {
                var counter = splitedText.Count(t => t.Contains(name));
                Console.WriteLine($"Name {name} is contained {counter}");
            }
            Console.ReadLine();
        }
    }
}
