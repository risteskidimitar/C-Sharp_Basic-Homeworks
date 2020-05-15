using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FakeFB.Logger
{
    public class AdminExceptionsLogger
    {
        private string FilePath { get; set; } = @"C:\Users\dimit\Desktop\Class15\ExceptionHandling\AdminExeptionLogger.txt";

        public void AdminLogExeption(Exception ex)
        {
            StreamWriter swAdmin = new StreamWriter(FilePath);
            swAdmin.WriteLine($"{ex.GetType().Name}  {ex.Message}  {ex.StackTrace}");
            swAdmin.Close();
        }
    }
}
