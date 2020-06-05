using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzApp
{
    public class Quiz
    {
        public static int startQuiz()
        {
            var rightAnswers = 0;
            Console.WriteLine("Q1");
            Console.WriteLine(@" What is the capital of Tasmania?
                                 a: Dodoma
                                 b: Hobart
                                 c: Launceston
                                 d: Wellington");
            Console.WriteLine("Enter your answer a,b,c,d");
            string anwer1 = Console.ReadLine().ToLower();
            if (anwer1 == "b") rightAnswers++;

            Console.WriteLine("Q2");
            Console.WriteLine(@" What is the tallest building in the Republic of the Congo?
                                a: Kinshasa Democratic Republic of the Congo Temple
                                b: Palais de la Nation
                                c: Kongo Trade Centre
                                d: Nabemba Tower");
            Console.WriteLine("Enter your answer a,b,c,d");
            string anwer2 = Console.ReadLine().ToLower();
            if (anwer2 == "d") rightAnswers++;

            Console.WriteLine("Q3");
            Console.WriteLine(@" Which of these is not one of Pluto's moons?
                                a: Styx
                                b: Hydra
                                c: Nix
                                d: Lugia");
            Console.WriteLine("Enter your answer a,b,c,d");
            string anwer3 = Console.ReadLine().ToLower();
            if (anwer3 == "c") rightAnswers++;

            Console.WriteLine("Q4");
            Console.WriteLine(@" What is the smallest lake in the world?
                                a: Onega Lake
                                b: Benxi Lake
                                c: Kivu Lake
                                d: Wakatipu Lake");
            Console.WriteLine("Enter your answer a,b,c,d");
            string anwer4 = Console.ReadLine().ToLower();
            if (anwer4 == "b") rightAnswers++;

            Console.WriteLine("Q5");
            Console.WriteLine(@" What country has the largest population of alpacas?
                                a: Chad
                                b: Peru
                                c: Australia
                                d: Niger");
            Console.WriteLine("Enter your answer a,b,c,d");
            string anwer5 = Console.ReadLine().ToLower();
            if (anwer5 == "b") rightAnswers++;

           Console.WriteLine($"You have correct answer/s on {rightAnswers} of 5 questions");
            return rightAnswers;
        }

    }
}
