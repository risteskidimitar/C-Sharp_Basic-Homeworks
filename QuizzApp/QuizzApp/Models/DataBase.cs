using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzApp.Models
{
    public static class DataBase
    {
        public static List<Student> GetStudent()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Username = "dimitar",
                    Password = "risteski",
                    
                },
                new Student()
                {
                    Username = "john",
                    Password = "john",
                },
                new Student()
                {
                    Username = "julia",
                    Password = "julia",
                },

            };
        }

        public static List<Teacher> GetTeacher()
        {
            return new List<Teacher>()
            {
                new Teacher()
                {
                    Username = "goce",
                    Password = "kabov",
                },
                new Teacher()
                {
                    Username = "miki",
                    Password = "cekic",
                },
                new Teacher()
                {
                    Username = "ivan",
                    Password = "trajcev",
                },
            };
        }
    }
}

