using System;

namespace Homework03CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 03");

            //EXERCISE 01:

            //Get an input number from the console
            //Print all numbers from 1 to that number
            //Get another input number from the console
            //Print all numbers from that number to 1

            Console.WriteLine("A: Please enter one number:");
            int input = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            while (input >= counter)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.ReadLine();

            Console.WriteLine("B: Please enter another number:");
            int anotherInput = Convert.ToInt32(Console.ReadLine());

            for (int i = anotherInput; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //EXERCISE 02:
            //Get an input number from the console
            //Print all even numbers starting from 2
            //Get another input number from the console
            //Print all odd numbers starting from 1

            Console.WriteLine("A: Insert a number: ");
            int inputE2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= inputE2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

            Console.WriteLine(" B: Insert new number: ");
            int inputE2b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= inputE2b; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();


            //EXERCISE 03:
            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N
            //Print all the names after user enters N
            //Hint: we need to use endless loop until user enter N, then we want to "break" the loop

            string[] myArray = new string[] { };
            var index = 0;
            string answer;
            string someName;

            while (true)
            {
                Console.WriteLine("Do you want to enter a name? Y or N ");
                answer = Console.ReadLine();

                if (answer.ToUpper() == "Y")
                {
                    Array.Resize(ref myArray, myArray.Length + 1);
                    Console.WriteLine("Please enter a name ");
                    someName = Console.ReadLine();
                    myArray[index] = someName;
                    index++;
                    continue;
                }
                else if (answer.ToUpper() == "N")
                {
                    foreach (string name in myArray)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a correct name");
                }
            }
            Console.ReadLine();

                                                                    

        }
    }
}
