using AcademyApp.Enums;

namespace AcademyApp.Entities
{
    // C# - Inheritance -> One of the MAIN Pillars of OOP
    public class Assistant : Participant
    {
        // Specific just for the Trainer entity
        public Assistant(string firstName, string lastName)
             : base(firstName, lastName)
        {
            Role = AcademyRole.Assistant;
        }

        public Assistant()
        {
            Role = AcademyRole.Assistant;
        }
        public string[] Homeworks;
    }
}