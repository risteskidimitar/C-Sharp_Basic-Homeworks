using QuizzApp.Models;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;

namespace QuizzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quizz App");
            var listOfStudets = DataBase.GetStudent();
            var listOfTeacher = DataBase.GetTeacher();
            int BadChoice = 0;
            bool exit = false;

            while (BadChoice <= 2 && exit == false)
            {
                Console.WriteLine("Press student, teacher or exit");
                var choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "student":

                        Console.WriteLine("Enter your username");
                        var username = Console.ReadLine();
                        Console.WriteLine("Enter your password");
                        var password = Console.ReadLine();
                        var myStudent = listOfStudets.SingleOrDefault(s => s.Username == username);

                        if (myStudent == null || myStudent.Password != password)
                        {
                            BadChoice++;
                            Console.WriteLine($"Incorrect username or password, you have {3 - BadChoice} more tries");
                        }
                        else if (myStudent.Password == password && myStudent.Logged == false)
                        {
                            myStudent.LoggChanger();
                            Console.WriteLine($"Thanks for loggin student {myStudent.Username}");

                            myStudent.Grade = Quiz.startQuiz();

                        }
                        else if (myStudent.Password == password && myStudent.Logged == true)
                        {
                            Console.WriteLine("You are already did the test");
                        }

                        break;

                    case "teacher":

                        Console.WriteLine("Enter your username");
                        username = Console.ReadLine();
                        Console.WriteLine("Enter your password");
                        password = Console.ReadLine();
                        var myTeacher = listOfTeacher.SingleOrDefault(t => t.Username == username);

                        if (myTeacher == null || myTeacher.Password != password)
                        {
                            BadChoice++;
                            Console.WriteLine($"Incorrect username or password, you have {3 - BadChoice} more tries");

                        }
                        else if (myTeacher.Password == password)
                        {
                            Console.WriteLine($"Thanks for loggin teacher {myTeacher.Username}");

                            myTeacher.PrintStudents(listOfStudets);
                            Console.ReadLine();
                        }
                        break;

                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again");
                        break;
                }
            }
        }
    }
}
