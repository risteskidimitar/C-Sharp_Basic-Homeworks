using System;

namespace Homework_Class_5
{
    //Task 7
    public class Dog
    {
        public Dog()
        {

        }
        public string Name;
        public string Race;
        public string Color;

        public void Eating()
        {
            Console.WriteLine("The dog is now eating");
        }

        public void Playing()
        {
            Console.WriteLine("The dog is now playing");
        }

        public void Chasing()
        {
            Console.WriteLine("Dog is now chasing its tail");
        }
    }

    //Task 9
    public class Human
    {
        public Human()
        {

        }
        public string FirstName;
        public string LastName;
        public int Age;

        public void GetPersonStats()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName}, at age of {Age}.");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework Class 5 📒");

            //Task 1 *Print individual characters of the string in reverse order. *Example: we love c# *Expected Output : #c evol ew

            string task1 = "we love c#";
            Console.WriteLine(Reverse(task1));


            //Task 2 *Count the total number of words in a string entered by the user. 
            //*Example: user enters "I love C#" *Expected output: "I love c#" contains 3 words. 


            string task2 = "we love c#";
            string[] splitedTextArr = task2.Split(" ");
            int count = splitedTextArr.Length;

            Console.WriteLine($" Number of words is {count}");


            //Task 3 *Find maximum occurring character in a string *Example: "We want this situation with covid-19 to ends!"
            //*Expected Output : The highest frequency of character 't' appears number of times : 6

            string task3 = "We want this situation with covid-19 to ends!";

            char[] cArray3 = task3.ToUpper().ToCharArray();
            int finalCount = 0;
            int count3 = 0;
            char Mychar = ' ';

            for (int i = 0; i < cArray3.Length; i++)
            {
                count3 = 1;
                for (int j = i + 1; j < cArray3.Length; j++)
                {
                    if (cArray3[i] == cArray3[j] && cArray3[i] != ' ')
                    {
                        count3++;
                        if (count3 >= finalCount)
                        {
                            finalCount = count3;
                            Mychar = cArray3[j];
                        }
                    }
                }
            }
            Console.WriteLine(cArray3);
            Console.WriteLine($"The highest frequency of character {Mychar}, appears number of times: {finalCount}");

            //Task 4 "The whole group of G1 loves C#, 
            //we are sure that with their deducation and passion they will be successfull programers soon!"
            // *Print the whole text after "," in the console. 
            //*Bonus - Try to do that without counting the characters till "," by yourself :)

            string printTask4 = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";
            string[] splitedTextArr4 = printTask4.Split(", ");

            Console.WriteLine(splitedTextArr4[splitedTextArr4.Length - 1]);// Bonusot?? 

            //Task 5 *Display the Day properties(year, month, day, hour, minute, second) from the today's date. *Expected Output : 
            //*year = 2020
            //* month = 3
            //* day = 26
            //* hour = 23
            //* minute = 12
            //* second = 22

            DateTime today = DateTime.Now;
            Console.WriteLine($" year = {today.Year}\n month = {today.Month}\n day = {today.Day}\n hour = {today.Hour}\n minute = {today.Minute}\n second = {today.Second}");


            //*Task 6 Find the leap years between 2008 and 2020. * Expected output: *2008 is a leap year. * 2012 is a leap year. 
            //* 2016 is a leap year. * 2020 is a leap year.
            //* Hint - make some researches of DateTime methods, you will find interesting ones that might help you;)


            for (int i = 2020; i >= 2008; i--)
            {
                if (DateTime.IsLeapYear(i))
                {
                    Console.WriteLine(i);
                }
            }

            //Task 7 

            var MyDog = new Dog();

            Console.WriteLine("Enter the name of the dog");
            MyDog.Name = Console.ReadLine();

            Console.WriteLine("Enter the race of the dog");
            MyDog.Color = Console.ReadLine();

            Console.WriteLine("Enter the color of the dog");
            MyDog.Color = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Does dog is eating? Y or N");

                string answer1 = Console.ReadLine().ToLower();

                if (answer1 == "y")
                {
                    MyDog.Eating();
                    break;
                }

                Console.WriteLine("Does dog is playing ? Y or N");

                string answer2 = Console.ReadLine().ToLower();

                if (answer2 == "y")
                {
                    MyDog.Playing();
                    break;
                }

                Console.WriteLine("Does dog is chasing its tail ? Y or N");

                string answer3 = Console.ReadLine().ToLower();

                if (answer3 == "y")
                {
                    MyDog.Chasing();
                    break;
                }
            }


            // Task 8

            Console.WriteLine("Do you want to create a object in C# of Human? Y or N ");
            var fromConsole8 = Console.ReadLine().ToLower();
            if (fromConsole8 == "y")
            {
                Human SomeUser = new Human();

                Console.WriteLine("Enter First Name");
                SomeUser.FirstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name");
                SomeUser.LastName = Console.ReadLine();

                Console.WriteLine("Enter age of the user");
                SomeUser.Age = int.Parse(Console.ReadLine());

                SomeUser.GetPersonStats();
            }



            Console.ReadLine();
        }

        //task01 with method

        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = "";
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }


    }
}
