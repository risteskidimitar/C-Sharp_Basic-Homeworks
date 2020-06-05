using System;
using System.Linq;

namespace TASK_02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                try
                {
                    Console.WriteLine("Please enter a day");
                    var inputedDay = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter a month");
                    var inputedMonth = int.Parse(Console.ReadLine());

                    var inputDate = $"{inputedDay}.{inputedMonth}";
                    string[] holidays = { "1.1", "7.1", "20.4", "1.5", "25.5", "2.8", "8.9", "12.10", "23.10", "8.12" };

                    DateTime convertDayToString = new DateTime(2020, inputedMonth, inputedDay); 
                    var day = convertDayToString.ToString("dddd");
                    Console.WriteLine($"The day is {day}");

                    if (day == "Saturday" || day == "Sunday")
                    {
                        Console.WriteLine("The date you inputted isn't a working day, it's weekend :) ");

                    }
                    else if (holidays.Contains(inputDate))
                    {
                        Console.WriteLine("The date you inputted isn't a working day, it's a holiday");
                    }
                    else
                    {
                        Console.WriteLine("The date you inputted is a working day");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorect date format, try again ");
                    continue;
                }

                break;
            }
            Console.ReadLine();

        }
    }
}
