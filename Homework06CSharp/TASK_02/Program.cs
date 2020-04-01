using System;

namespace TASK_02
{
    public class FirstCourse
    {
        public FirstCourse(string nameOfCourse, bool itsPassed)
        {
            courseName = nameOfCourse;
            pass = itsPassed;
        }

        public string courseName;
        public bool pass;

        public bool Passed()
        {
            if (pass)
            {
                return true;
            }
            else { return false; }
        }
    }
    public class SecondCourse
    {
        public SecondCourse(string nameOfCourse, gradeOfTheStudent enterGrade)
        {
            courseName = nameOfCourse;
            grade = enterGrade;
        }

        public string courseName;
        public gradeOfTheStudent grade;

        public bool Passed()
        {
            if ((int)grade != 5)
            {
                return true;
            }
            else { return false; }
        }
    }

    // ENUM

    public enum gradeOfTheStudent
    {
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5
    }

    public class Project
    {
        public Project(bool a1, bool a2, bool a3, bool a4)
        {
            property1 = a1;
            property2 = a2;
            property3 = a3;
            property4 = a4;
        }

        bool property1;
        bool property2;
        bool property3;
        bool property4;

        public void FinalPassed()
        {
            int sum = 0;
            bool[] Barray = { property1, property2, property3, property4 };

            foreach (var item in Barray)
            {
                if (item == true)
                {
                    sum++;
                }
            }
            if (sum >= 3)
            {
                Console.WriteLine($" Student has passed with {sum} of 4");
            }
            else { Console.WriteLine($" Student has NOT passed with {sum} of 4"); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Course1 = new FirstCourse("SEDC", true);
            var Course2 = new FirstCourse("English", true);

            var Course3 = new SecondCourse("Ekonomski", gradeOfTheStudent.Eight);
            var Course4 = new SecondCourse("Finki", gradeOfTheStudent.Five);

            Project FinalGrade = new Project(Course1.Passed(), Course2.Passed(), Course3.Passed(), Course4.Passed());

            FinalGrade.FinalPassed();

            Console.ReadLine();
        }
    }
}
