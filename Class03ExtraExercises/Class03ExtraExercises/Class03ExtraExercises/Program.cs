using System;

namespace Class03ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extra 7th Exercises");

            //   1.Write a C# Sharp program to find the sum of first 10 natural numbers
            //    *Hint: The first 10 natural number are: 1 2 3 4 5 6 7 8 9 10


            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Result is: {sum}");
            Console.ReadLine();

            //2.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.


            int count = 1;
            int number;
            int sum02 = 0;

            while (count <= 10)
            {
                Console.WriteLine($"Please enter {count} number");
                number = Convert.ToInt32(Console.ReadLine());
                sum02 += number;
                count++;
            }
            Console.WriteLine($" Sum is: {sum02}, Average is: {sum02 / count}");
            Console.ReadLine();


            //3.Declare and init array of 10 integers by your choise. 
            //   Find maximum and minimum element in that array and their indexes.

            int[] numArray = new int[10] { 55, 6, 77, 3, 26, 14, 77, 44, 87, 30 };

            int max = numArray[0];
            int min = numArray[0];

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] >= max)
                {
                    max = numArray[i];
                }
                if (numArray[i] <= min)
                {
                    min = numArray[i];
                }
            }

            int indexOfMin = Array.IndexOf(numArray, min);
            int indexOfMax = Array.IndexOf(numArray, max);

            Console.WriteLine($"Minimum number in the array is {min} at index {indexOfMin}");
            Console.WriteLine($"Minimum number in the array is {max} at index {indexOfMax}");

            Console.ReadLine();

            //4.arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9] 
            //   Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates

            int[] arrayWithDuplicates = new int[] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };

            int count4 = 0;

            for (int i = 0; i < arrayWithDuplicates.Length; i++)
            {
                for (int j = i + 1; j < arrayWithDuplicates.Length; j++)
                {
                    if (arrayWithDuplicates[i] == arrayWithDuplicates[j])
                    {
                        count4++;
                        break;
                    }
                }
            }

            Console.WriteLine($"Total number of duplicates in the array is {count4}");
            Console.ReadLine();

            //5.oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            //   Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays

            int[] oddEvenArray = { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };

            int[] evenArray = new int[] { };
            int[] oddArray = new int[] { };
            int index5 = 0;
            int counter5 = 0;

            for (int i = 0; i < oddEvenArray.Length; i++)
            {
                if (oddEvenArray[i] % 2 == 0)
                {
                    Array.Resize(ref evenArray, evenArray.Length + 1);
                    evenArray[index5] = oddEvenArray[i];
                    index5++;
                }
                else if (oddEvenArray[i] % 2 != 0)
                {
                    Array.Resize(ref oddArray, oddArray.Length + 1);
                    oddArray[counter5] = oddEvenArray[i];
                    counter5++;
                }
            }

            Console.WriteLine("My even array");
            foreach (var item in evenArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("My odd array");
            foreach (var item in oddArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //6.Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            // the day with strings.Example: user enters 1, you should print Monday.


            Console.WriteLine("Enter a Day as number from 1 to 7");
            var consoleInput = Console.ReadLine();
            int input6;
            bool convertStatus = int.TryParse(consoleInput, out input6);

            if (convertStatus == true && input6 <= 7 && input6 > 0)
            {
                switch (input6)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("ERROR");//ne mi treba :)
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.ReadLine();



            //7. userNames = ["user1", "user2", "user3"]
            //   passwords = ["first", "second", "third"]
            //   Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //   Create a logic when user enters specific username to provide a correct password for that user, and when that
            //   happens you should print on the screen "You are logged in successfully".
            //   If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //   repeat the proccess from begining while he / she doesn't input correct username and password.


            //   Note: Every element in userNames corresponds with the element in passwords at same index.
            //   Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third".

            string[] userNames = { "user1", "user2", "user3" };
            string[] passwords = { "first", "second", "third" };

            bool stop = false;

            while (true)
            {
                Console.WriteLine("Enter your username");
                string user = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string pass = Console.ReadLine();

                for (int i = 0; i < userNames.Length; i++)
                {
                    if (user == userNames[i] && passwords[i] == pass)
                    {
                        stop = true;        
                    }
                }
                
                if (stop == true)
                {
                    Console.WriteLine("You are logged in successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password");
                }

            }
            Console.ReadLine();


        }
    }
}
