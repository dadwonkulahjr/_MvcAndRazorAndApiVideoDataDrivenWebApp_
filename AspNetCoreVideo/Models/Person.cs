using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Salary { get; set; }
        public Person(int personId, string firstName, 
            string lastName, decimal? salary)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
    }
}
