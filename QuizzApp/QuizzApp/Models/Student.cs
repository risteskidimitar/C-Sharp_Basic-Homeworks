using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzApp.Models
{
    public class Student : User
    {
        public int Grade;
        public bool Logged = false;
        public bool LoggChanger()
        {
            return Logged = true;
        }

    }
}
