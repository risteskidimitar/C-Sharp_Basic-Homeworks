using AcademyApp.Enums;
using System;
using System.Collections.Generic;

namespace AcademyApp.Entities
{
    public class Participant
    {
        public Participant()
        {

        }

        public Participant(string firstName)
        {
            FirstName = firstName;
        }

        public Participant(string firstName, string lastName)
        {

            FirstName = firstName;
            LastName = lastName;
        }

        //FIELD -> PROPERTY
        //protected int Age;
        protected int Age { get; set; }

        //FIELDS
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Subject> Subjects { get; set; }
        public AcademyRole Role { get; set; }

        public void Greetings()
        {
            Console.WriteLine($"Hello, I`m {FirstName} {LastName}");

            HowOld(DateTime.Today);
            Console.WriteLine($"Also, I`m {Age} years old. :)");
        }

        private void HowOld(DateTime today)
        {
            if (today.Month <= DateOfBirth.Month && today.Day < DateOfBirth.Day)
            {
                Age = today.Year - DateOfBirth.Year - 1;
            }
            else { Age = today.Year - DateOfBirth.Year; }

        }

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}