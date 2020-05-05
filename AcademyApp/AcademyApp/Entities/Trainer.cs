using AcademyApp.Enums;
using System;

namespace AcademyApp.Entities
{
    // C# - Inheritance -> One of the MAIN Pillars of OOP
    public class Trainer : Participant
    {
        public Expertise Expertise { get; set; }

       private bool EnglishLanguage { get; set; }


        public Trainer()
        {
            Role = AcademyRole.Trainer;
        }
        public Trainer(string firstName, string lastName)
            : base(firstName, lastName)
        {
            EnglishLanguage = true;
            Role = AcademyRole.Trainer;
        }
    }
}
