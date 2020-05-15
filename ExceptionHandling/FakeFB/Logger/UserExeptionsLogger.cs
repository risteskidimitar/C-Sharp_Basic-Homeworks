using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FakeFB.Logger
{
    public class UserExceptionsLogger
    {
        private string FilePath { get; set; } = @"D:\SEDC_19\Sessions\05_C#_Basic\Homework\ExceptionHandling\UserExceptionLogger.txt";
        public void LogExeption(Exception ex)
        {
            StreamWriter sw = new StreamWriter(FilePath);
            sw.WriteLine($"{ex.GetType().Name}  {ex.Message}  {ex.StackTrace}");
            sw.Close();
        }
    }
}
