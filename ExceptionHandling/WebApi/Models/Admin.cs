using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Models
{
    public class Admin : Person
    {
        public List<Admin> Friends { get; set; }
    }
}
