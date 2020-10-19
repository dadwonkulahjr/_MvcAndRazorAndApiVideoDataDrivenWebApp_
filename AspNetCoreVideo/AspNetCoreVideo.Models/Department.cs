using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.AspNetCoreVideo.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Department(int departmentId, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }
        public static List<Department> GetAllDeparments()
        {
            return new List<Department>()
            {
                new Department(departmentId:101, departmentName:"IT"),
                new Department(departmentId:102, departmentName:"HR"),
                new Department(departmentId:103, departmentName:"Payroll")
            };
        }

    }
}
