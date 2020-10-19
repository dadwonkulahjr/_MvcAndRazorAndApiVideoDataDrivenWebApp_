using AspNetCoreVideo.tuseTheProgrammer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.AspNetCoreVideo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double? Salary { get; set; }
        public Department Department { get; set; }
        public List<string> Address { get; protected set; } = new List<string>()
        {
            "Bardnesville",
            "New Georgia Estate",
            "Stephen Tolbert",
            "Battery Factory",
            "Bardnesville Estate"
        };
    }
}
