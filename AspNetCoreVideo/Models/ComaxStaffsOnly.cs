using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Models
{
    public class ComaxStaffsOnly
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public ComaxStaffsOnly(int staffId, string firstName,
            string lastName, string gender)
        {
            StaffId = staffId;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
    }
}
