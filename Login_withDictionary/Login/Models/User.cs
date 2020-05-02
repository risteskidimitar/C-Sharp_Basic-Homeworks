using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Models
{
   public class User
    {
        public User()
        {
            NameAndPass = new Dictionary<string, string>();
        }
        public Dictionary<string, string> NameAndPass { get; set; }    
    }
}
