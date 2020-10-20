using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Entities
{
    public class Department
    {
        public int Id { get; set; }
        [Display(Name ="Department Name")]
        [Required]
        [Column(name:"Department Name", TypeName ="int")]
        public Dept DepartmentName { get; set; }
        public enum Dept : int { IT = 1, HR = 2, Payroll = 3 }
    }
}
