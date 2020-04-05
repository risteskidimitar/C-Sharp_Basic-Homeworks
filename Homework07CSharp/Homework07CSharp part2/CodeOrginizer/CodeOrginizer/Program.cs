using CodeOrginizer.Enums;
using System;
using CodeOrginizer.Personal_Info;
using CodeOrginizer.Helpers;

namespace CodeOrginizer
{

    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John", 22);
            john.Address = new Address();
            john.Address.Name = "Wall street";
            john.Address.Number = 24;
            john.SSN = GenetarionSSN.GenerateSSN();
            john.PrintPerson();

            Console.WriteLine("------------------------------------");

            Address bobsAdress = new Address()
            {
                Name = "Next To Wallstreet",
                Number = 1000
            };
            Address bobWorkingAdress = new Address()
            {
                Name = "Two streets after Wallstreet",
                Number = 101
            };
            Person bob = new Person()
            {
                Name = "Bob",
                Age = 55,
                Address = bobsAdress,
                SSN = GenetarionSSN.GenerateSSN(),
                Job = new Job()
                {
                    Address = bobWorkingAdress,
                    CompanyName = "G1",
                    Role = Role.Designer
                }
            };

            Address DimRisAddress = new Address
            {
                Name = "London City",
                Number = 2000
            };

            Address DimRisWork = new Address
            {
                Name = "1 Churchill Place",
                Number = 2000,
            };


            Person DimRis = new Person()
            {
                Name = "Dimitar",
                Age = 31,
                Address = DimRisAddress,
                SSN = GenetarionSSN.GenerateSSN(),

                Job = new Job()
                {
                    CompanyName = "Barclays",
                    Address = DimRisWork,
                    Role = Role.WebDeveloper,    
                }

            };
        

            bob.DevelopersSeacret();
            Console.WriteLine("------------------------------------");

            DimRis.PrintPerson();
            DimRis.DevelopersSeacret();

            Console.ReadLine();
        }

    }



}
