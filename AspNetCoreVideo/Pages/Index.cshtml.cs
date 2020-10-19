using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.AspNetCoreVideo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreVideo.tuseTheProgrammer
{
    public class IndexModel : PageModel
    {
        private readonly string _devName = "Dad S Wonkulah Jr";
        public List<Employee> ListOfEmployees { get; set; }
        public List<Student> ListOfStudents { get; set; }
        public List<string> Messages { get; set; }
        public void OnGet()
        {
            Messages = new List<string>()
            {
                "Hi Welcome, my name is " + _devName + ", I love writing computer software!" +
                "The current time and date check in the city is " + DateTime.UtcNow.ToLocalTime()
            };

            ListOfEmployees = GetEmployees();
            ListOfStudents = GetStudents();


        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(){EmployeeId = 101, Name = "Mike Simsons", Email="mike@m.com", Salary=50000, Department = new Department(departmentId:101,departmentName:"IT")},
                new Employee(){EmployeeId = 102, Name = "Mary Brown", Email="mary@m.com", Salary=25000,Department = new Department(departmentId:102,departmentName:"HR")},
                new Employee(){EmployeeId = 103, Name = "Sam Wilson", Email="sam@s.com", Salary=40000,Department = new Department(departmentId:101,departmentName:"IT")},
                new Employee(){EmployeeId = 104, Name = "Sara Marshall", Email="sara@s.com", Salary=26000,Department = new Department(departmentId:102,departmentName:"HR")},
                new Employee(){EmployeeId = 105, Name = "Alex Weah", Email="alex@a.com", Salary=20000,Department = new Department(departmentId:103,departmentName:"Payroll")},
                new Employee(){EmployeeId = 106, Name = "Beatrice Wilson", Email="b@b.com", Salary=2000,Department = new Department(departmentId:103,departmentName:"Payroll")},
                new Employee(){EmployeeId = 107, Name = "Prince Walker", Email="p@p.com", Salary=20000,Department = new Department(departmentId:101,departmentName:"IT")}
            };
        }
        private List<Student> GetStudents()
        {
            return new List<Student>()
                                {
                                    new Student(){StudentId=101, StudentName="Mike Pin", StudentTotalMarks=88, Courses=
                                    new List<string>(){"MVC", "Razor Pages", "Database Fundamentals", "REST"} },
                                    new Student(){StudentId=102, StudentName="Chelsea Collins", StudentTotalMarks=77, Courses=
                                    new List<string>(){"REST", "MVC", "Razor Pages", "Software Development" } },
                                    new Student(){StudentId=103, StudentName="Beatrice Paye", StudentTotalMarks=88, Courses=
                                    new List<string>(){"C#", "Mobile Development", "Razor Pages", "MVC"} },
                                    new Student(){StudentId=104, StudentName="Alex Weah", StudentTotalMarks=88, Courses=
                                    new List<string>(){ "C#", "Mobile Development", "MVC", "SVRF"} }
                                };
        }
    }

}



