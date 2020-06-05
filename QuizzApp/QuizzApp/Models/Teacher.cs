using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizzApp.Models
{
    public class Teacher: User
    {

        public void PrintStudents(List<Student> someList)
        {
            foreach (var student in someList)
            {
                if (student.Logged)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Student {student.Username}, with grade of {student.Grade}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(student.Username);
                    Console.ResetColor();
                }
            }
        }
    }
}
