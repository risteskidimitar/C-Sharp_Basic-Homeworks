using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzApp.Models
{
    public class User
    {
        static int counter = 100;
        public User()
        {
            counter += 1;
            _ID = counter;
        }
        private int _ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int GetId()
        {
            return _ID;
        }
    }
}
