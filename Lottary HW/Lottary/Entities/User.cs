using System;
using System.Collections.Generic;
using System.Text;

namespace Lottary.Entities
{
    public class User
    {
        public User()
        {

        }
        public User(string name)
        {
            FullName = name;
        }

        public string FullName { get; set; }
        private int Age { get; set; }

        public void BuyTicket(string name)
        {
            Console.WriteLine($"{name} got new ticket");
        }


        public void SetAge(int age)
        {
            if (age < 18)
                Console.WriteLine("Not allow for users under age of 18");
            else Age = age;        
        }
    }
}
