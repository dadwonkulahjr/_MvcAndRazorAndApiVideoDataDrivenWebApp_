using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.ViewModels
{
    public class RegisterViewModel
    {
        [Required, MaxLength(255)]
        public string Username { get; set; }
        [DataType(DataType.Password), Required]
        public string Password { get; set; }
        [Required, DataType(DataType.Password),
            Compare(nameof(Password), ErrorMessage ="Password and compare password must match."),
            Display(Name ="Confirm Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public Gender? Gender { get; set; }
    }
}
