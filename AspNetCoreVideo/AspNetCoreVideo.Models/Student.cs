using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.AspNetCoreVideo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentTotalMarks { get; set; }
        public List<string> Courses { get; set; }
    }
}
