using AcademyApp.Enums;
using System;

namespace AcademyApp.Entities
{
    // C# - Inheritance -> One of the MAIN Pillars of OOP
    public class Student : Participant
    {
        // Specific just for the Student entity
        public int Group { get; set; }
        public Student()
        {
            Role = AcademyRole.Student;
        }
        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
            Role = AcademyRole.Student;
        }

        public void FavouriteHomework(Subject subject)
        {
            switch (subject.Title)
            {
                case "C# Basic":
                    Console.WriteLine("Traffic light homework :))!");
                    break;
                default:
                    break;
            }
        }
    }
}
