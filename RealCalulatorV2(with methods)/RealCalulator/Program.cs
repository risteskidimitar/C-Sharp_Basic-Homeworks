using System;

namespace RealCalulator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
               
                float result;
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Insert one opertion (+, -, *, /)");
                string operation = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Insert the first number");
                string strNumber1 = Console.ReadLine();
                float number1;
                bool boolnumber1 = float.TryParse(strNumber1, out number1);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Insert the second number");
                string strNumber2 = Console.ReadLine();
                float number2;
                bool boolnumber2 = float.TryParse(strNumber2, out number2);
                string say = "Thanks for using this caluculator";


                if (boolnumber1 == false || boolnumber2 == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid numbers, please insert corect numbers");
                    continue;
                }

                switch (operation)
                {
                    case "+":
                        result = Addition(number1, number2);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{number1} {operation} {number2} = {result}");
                        break;

                    case "-":

                        result = Subtraction(number1, number2);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{number1} {operation} {number2} = {result}");
                        break;

                    case "*":

                        result = Multiplication(number1, number2);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{number1} {operation} {number2} = {result}");
                        break;

                    case "/":
                        if (number2 != 0)
                        {
                            result = Division(number1, number2);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{number1} {operation} {number2} = {result}");
                        }
                        else
                        {
                            result = 0;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Division with zero is not possible");
                        }
                        break;

                    default:
                        result = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid arithmetic operation");
                        break;
                }
                if (Console.ReadLine() == "s")
                {
                    Console.ResetColor();
                    Console.WriteLine("Thanks for using this caluculator");
                    Console.ReadLine();
                    break;
                }

            }
           
        }
        // methods
        public static float Multiplication(float num1, float num2)
        {
            return num1 * num2;
        }
        public static float Division(float num1, float num2)
        {
            return num1 / num2;
        }

        public static float Addition(float num1, float num2)
        {
            return num1 + num2;
        }
       public static float Subtraction(float num1, float num2)
        {
            return num1 - num2;
        }


    }
}
