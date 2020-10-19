using AspNetCoreVideo.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Entities
{
    public class CustomUser : IdentityUser
    {
        public string Address { get; set; }
        [Required]
        public Gender? Gender { get; set; }
        

    }
}
