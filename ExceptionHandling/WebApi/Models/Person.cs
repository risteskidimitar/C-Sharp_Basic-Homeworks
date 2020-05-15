using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GetUserId()
        {
            return Id;
        }
    }
}
