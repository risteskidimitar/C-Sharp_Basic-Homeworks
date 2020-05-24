using Lottary.Entities;
using Lottary.Enums;
using Lottary.Helpers;
using System;

namespace Lottary
{
    class Program
    {
        public static Ticket[] Tickets { get; private set; }

        static void Main(string[] args)
        {
            //Create structure
            //Create models
            User user = new User()
            {
                FullName = "Igor Dzambazov"
            };
            user.SetAge(55);
            user.BuyTicket(user.FullName);

            Ticket ticket = new Ticket()
            {
                Combination = new int[] { 3, 9, 26, 19, 24, 17, 7 },
                User = user,
            };

            User user1 = new User ("Dimitar Risteski");
            user1.SetAge(31);
            user1.BuyTicket(user1.FullName);


            Ticket ticket1 = new Ticket()
            {
                Combination = new int[] { 6, 9, 26, 31, 22, 2, 7 },
                User = user1,
            };



            User user2 = new User("James Bond");
            user2.SetAge(35);
            user2.BuyTicket(user2.FullName);

            Ticket ticket2 = new Ticket()
            {
                Combination = new int[] { 0, 7, 15, 10, 24, 15, 29 },
                User = user2,
            };

            User user3 = new User("Natali");
            user3.SetAge(25);
            user3.BuyTicket(user3.FullName);


            Ticket ticket3 = new Ticket()
            {
                Combination = new int[] { 3, 13, 20, 24, 25, 4, 23 },
                User = user3,
            };


            FirstSession firstSession = new FirstSession()
            {
                Tickets = new Ticket[] { ticket }
            };

            firstSession.StartSession();
            foreach (var number in ticket.Combination)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("--------------------");
            foreach (var number in firstSession.WinningCombination)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("--------------------");


            var matches = LottaryHelpers.CheckTicket(firstSession.WinningCombination, ticket.Combination);

            switch (matches)
            {
                case (int)Prize.TV:
                    Console.WriteLine(Prize.TV);
                    break;
                case (int)Prize.Vacation:
                    Console.WriteLine(Prize.Vacation);
                    break;
                case (int)Prize.MotorBike:
                    Console.WriteLine(Prize.MotorBike);
                    break;
                case (int)Prize.Car:
                    Console.WriteLine(Prize.Car);
                    break;
                default:
                    Console.WriteLine("Ticket without win");
                    break;
            }

            //firstSession.GetRandomTicket();

            Console.ReadLine();
        }
    }
}
