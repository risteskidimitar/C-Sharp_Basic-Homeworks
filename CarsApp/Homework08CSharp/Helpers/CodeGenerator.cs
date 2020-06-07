using System;
using System.Collections.Generic;
using System.Text;

namespace Homework08CSharp.Helpers
{
   internal class CodeGenerator
    {
        public static int RandomCodeGnerator()
        {
            Random code = new Random();
            return code.Next(1000, 9999);
         
        }
    }
}
