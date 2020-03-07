using System;

namespace Homework02CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOMEWORK 02");

            //Exercise 01:

            string firstName = "Dimitar";
            string lastName = "Risteski";
            Console.WriteLine($"Hello {firstName}  {lastName}");

            string number01 = "9";

            string number02 = "3";

            Console.WriteLine(number01 + number02);
            Console.ReadLine();

            // Exercise 02:    

            int number03 = 31;
            string name = "Dime";
            Console.WriteLine(number03 + " " + firstName);
            Console.ReadLine();

            // Exercise 03:  

            int n = 102;
            int m = 5;
            int result = n / m;

            Console.WriteLine(result + "SMS");
            Console.ReadLine();

            //Exercise 04 (* BONUS)

            Console.WriteLine("Enter your number:");
            string input = Console.ReadLine();

            int parsedNumber;
            bool parsingSuccsess = int.TryParse(input, out parsedNumber);

            if (parsingSuccsess)
            {
                if (parsedNumber % 2 == 0)
                {
                    Console.WriteLine("It`s EVEN");

                }
                else
                {
                    Console.WriteLine("It`s ODD");

                };

                }
            else {
                Console.WriteLine("Please enter a correct number");
                               
            };
            Console.ReadLine();

        }
    }
}
