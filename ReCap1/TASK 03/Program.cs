using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TASK_03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int userScore = 0;
            int appScore = 0;

            while (flag)
            {

                Console.WriteLine("PRESS: 1.PLAYING  2.STATS  3.EXIT");
                var menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        Console.WriteLine("PRESS:  1.ROCK  2.PAPER  3.SCISSORS");
                        string stringPick = Console.ReadLine();
                        int parsedPick;
                        bool converting = int.TryParse(stringPick, out parsedPick);
                        if (converting == false) continue;
                        var userPick = (Game)parsedPick;

                        int random = new Random().Next(1, 3);
                        var applicationPick = (Game)random;
                        Console.WriteLine($"You pick: {userPick}");
                        Console.WriteLine($"Application pick: {applicationPick}");

                        if ((userPick == Game.Rock && applicationPick == Game.Scissors)
                            || (userPick == Game.Scissors && applicationPick == Game.Paper)
                            || (userPick == Game.Paper && applicationPick == Game.Rock))
                        {
                            userScore++;
                            Console.WriteLine("User wins");

                        }
                        else if ((applicationPick == Game.Rock && userPick == Game.Scissors)
                            || (applicationPick == Game.Scissors && userPick == Game.Paper)
                            || (applicationPick == Game.Paper && userPick == Game.Rock))
                        {
                            appScore++;
                            Console.WriteLine("Applications wins");
                        }
                        else
                        {
                            Console.WriteLine("It's draw or invalid input");
                        }                        
                        break;

                    case "2":
                        Console.WriteLine($"User have {userScore} wins, or {wonRatio(userScore, appScore)} % Won ratio");
                        Console.WriteLine($"App have {appScore} wins, or {wonRatio(appScore, userScore) } % Won ratio");
                        break;

                    case "3":
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Something wrong");
                        break;
                }
            }

        }

       public static float wonRatio(float yourscore, float otherscore)
        {
            return (yourscore / (yourscore + otherscore)) * 100;
        }
    }
}
