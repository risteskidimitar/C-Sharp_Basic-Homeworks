using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Models
{
    public class User : Person
    {
        public List<User> Friends { get; set; }
    }
}
