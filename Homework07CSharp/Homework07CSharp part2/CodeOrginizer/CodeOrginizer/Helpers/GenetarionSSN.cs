using System;
using System.Collections.Generic;
using System.Text;

namespace CodeOrginizer.Helpers
{
    class GenetarionSSN
    {
        public static long GenerateSSN()
        {
            Random rand = new Random();
            return rand.Next(1000000, 9999999);
        }
    }
}
