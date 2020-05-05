using AcademyApp.Entities;
using AcademyApp.Enums;
using AcademyApp.Helpers;
using SubjectServices;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Trainer trainer = new Trainer("Miodrag", "Cekikj");
            trainer.DateOfBirth = new DateTime(1989, 5, 15);

            trainer.Subjects = new List<Subject>
            {
                new Subject()
                {
                    Title = "C# Basic",
                    Semester = 2,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio 2019",
                        AlternativeIDE = "Visual Studio Code"
                    }
                },
                new Subject()
                {
                    Title = "C# Advanced",
                    Semester = 2,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio 2019",
                        AlternativeIDE = "Visual Studio Code"
                    }
                }
            };

            trainer.Greetings();

            var assistant = new Assistant();
            assistant.FirstName = "Goce";
            assistant.LastName = "Kabov";
            assistant.DateOfBirth = new DateTime(1992, 5, 15);
            assistant.Greetings();

            var bob = new Assistant("Bob", "Marley");
            bob.Role = AcademyRole.Assistant;

            bob.Subjects = new List<Subject>
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            var student = new Student()
            {
                FirstName = "Dimitar",
                LastName = "Risteski",
                DateOfBirth = new DateTime(1988, 5, 15),

        };

            student.Subjects = new List<Subject>
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


            student.Greetings(); 

            foreach (var subject in student.Subjects)
            {
                Console.WriteLine(subject.Title);
            }

            var student2 = new Student()
            {
                FirstName = "Tupac",
                LastName = "Shakur"
            };

            var cSharpBasic = new Subject();
            cSharpBasic.Title = "C# Basic";
            cSharpBasic.Semester = 2;

            var cSharpAdvanced = new Subject();
            cSharpAdvanced.Title = "C# Advanced";
            cSharpAdvanced.Semester = 2;

            student2.Subjects = new List<Subject>();
            student2.Subjects.Add(cSharpBasic);
            student2.Subjects.Add(cSharpAdvanced);

            foreach (var subject in student2.Subjects)
            {
                Console.WriteLine(subject.Title);
            }


            var participants = new Queue<Participant>();

            participants.Enqueue(trainer);
            participants.Enqueue(assistant);
            participants.Enqueue(bob);
            participants.Enqueue(student);
            participants.Enqueue(student2);

            ParticipantHelper.FindParticipantByRole(participants, AcademyRole.Trainer);
            ParticipantHelper.FindParticipantByRole(participants, AcademyRole.Assistant);
            ParticipantHelper.FindParticipantByRole(participants, AcademyRole.Student);

            Console.ReadLine();
        }
    }
}