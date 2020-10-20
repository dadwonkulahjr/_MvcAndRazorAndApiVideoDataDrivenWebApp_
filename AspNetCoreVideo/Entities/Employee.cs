using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(50)")]
        [Display(Name ="First Name")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        [Column(TypeName ="decimal(18,0)")]
        public decimal? Salary { get; set; }
        [ForeignKey("DepartmentId")]
        public Department.Dept DepartmentId { get; set; }
        [ForeignKey("GenderId")]
        public Sex.Gender GenderId { get; set; }
    }
}
