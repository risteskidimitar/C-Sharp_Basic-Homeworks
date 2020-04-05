using AcademyApp.Entities;
using AcademyApp.Enums;
using AcademyApp.Helpers;
using SubjectServices;
using System;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant participant1 = new Participant();
            participant1.FirstName = "Miodrag";
            participant1.LastName = "Cekikj";
            participant1.DateOfBirth = new DateTime(1989, 5, 15);
            participant1.Role = AcademyRole.Trainer;

            participant1.Subjects = new Subject[]
            {
                new Subject()
                {
                    Title = "C# Basic",
                    Semester = 2,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio",
                        AlternativeIDE = "Visual Studio Code"
                    }
                },
                new Subject()
                {
                    Title = "C# Advanced",
                    Semester = 2,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio",
                        AlternativeIDE = "Visual Studio Code"
                    }
                }
            };

            participant1.Greetings();

            var participant2 = new Participant();
            participant2.FirstName = "Goce";
            participant2.LastName = "Kabov";
            participant2.DateOfBirth = new DateTime(1992, 5, 15);
            participant2.Role = AcademyRole.Assistant;
            participant2.Greetings();

            participant2.Subjects = new Subject[]
            {
                new Subject()
                {
                    Title = "HTML",
                    Semester = 1,
                    Tools = new Tooling()
                    {
                        MainIDE = "Sublime",
                        AlternativeIDE = "N/A",
                    }
                },
                new Subject()
                {
                    Title = "CSS",
                    Semester = 1,
                    Tools = new Tooling()
                    {
                        MainIDE = "Sublime",
                        AlternativeIDE = "N/A",
                    }
                }

            };

            var participant3 = new Participant("Bob", "Marley");
            participant3.Role = AcademyRole.Assistant;
            Console.ForegroundColor = ConsoleColor.Yellow;
            participant3.PrintFullName();

            participant3.Subjects = new Subject[] 
            {
                 new Subject
                {
                    Title = ".NET",
                    Semester = 3,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio",
                        AlternativeIDE = "Visual Studio Code",

                    }
                },
                new Subject
                {
                    Title = ".NET - Advanced ",
                    Semester = 3,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio",
                        AlternativeIDE = "Visual Studio Code",
                    }
                },

            };

            var participant4 = new Participant()
            {
                FirstName = "Dimitar",
                LastName = "Risteski",
                Role = AcademyRole.Student,
            };

            participant4.Subjects = new Subject[]
            {
                new Subject
                {
                    Title = "Java Script Basic",
                    Semester = 1,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio Code",
                        AlternativeIDE = "Sublime",

                    }
                },
                new Subject
                {
                    Title = "Java Script Advanced",
                    Semester = 1,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio Code",
                        AlternativeIDE = "Sublime",
                    }
                },
            };
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Check: Name {participant4.FirstName} Role:{participant4.Role} " +
                $"\nTitle: {participant4.Subjects[1].Title} code: {participant4.Subjects[1].Tools.Code} \n" +
                $"MainIDE {participant4.Subjects[1].Tools.MainIDE}");

            Console.ResetColor();

            foreach (var subject in participant4.Subjects)
            {
                Console.WriteLine(subject.Title);
            }

            participant4.PrintFullName();

            var participants = new Participant[4];
            participants[0] = participant1;
            participants[1] = participant2;
            participants[2] = participant3;
            participants[3] = participant4;

            ParticipantHelper.FindParticipantByRole(participants, AcademyRole.Trainer);

            Console.ReadLine();
        }
    }
}