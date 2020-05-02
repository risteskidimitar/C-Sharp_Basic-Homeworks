using Calculator.Models;
using System;
using System.Collections.Generic;

namespace Digitron
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 40, 30, 5 };
            int maxNumber = Calc.Max(numbers);
            Console.WriteLine(maxNumber);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(Calc.Avg(numbers));
            Console.WriteLine("----------------------------------");
            Console.WriteLine(Calc.DivPI(numbers));
            Console.WriteLine("----------------------------------");
            Console.WriteLine(Calc.Min(numbers));
            Console.WriteLine("----------------------------------");
            Console.WriteLine(Calc.Sum(numbers));
            Console.ReadLine();

        }
    }
}
