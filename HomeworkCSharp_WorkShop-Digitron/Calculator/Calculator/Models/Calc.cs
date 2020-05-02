using Calculator.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Models
{
    public static class Calc
    {
        public static decimal Avg (List<int> numbers)
        {
            return HelpersMethods.CalculateAverage(numbers);
        }
        public static int Max (List<int> numbers)
        {
            return HelpersMethods.FindMaxNumber(numbers);
        }

        public static int Min(List<int> numbers)
        {
            return HelpersMethods.FindMinNumber(numbers);
        }

        public static int Sum(List<int> numbers)
        {
            return HelpersMethods.CalculateSum(numbers);
        }

        public static double DivPI(List<int> numbers)
        {
            return HelpersMethods.dividedWithP1(numbers);
        }
    }
}
