using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Entities
{
    public class Sex
    {
        public int Id { get; set; }
        [Display(Name = "Gender")]
        [Required]
        [Column(name: "Gender", TypeName = "int")]
        public Gender Name { get; set; }
        public enum Gender : int { Male = 1, Female = 2, Unknown = 3 }
    }
}
