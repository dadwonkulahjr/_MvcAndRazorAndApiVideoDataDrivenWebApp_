using AspNetCoreVideo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Entities
{
    public class Video
    {
        public int Id { get; set; }
        [Required, MaxLength(80, ErrorMessage ="Video title cannot exceed 80 characters."),
            MinLength(3, ErrorMessage ="Characters should be minimun 3")]
        public string Title { get; set; }
        [Required]
        [Display(Name ="Film Genre")]
        public Genres? Genre { get; set; }
    }
}
