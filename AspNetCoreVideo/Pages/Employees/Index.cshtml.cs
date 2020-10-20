using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.AspNetCoreVideo.Models;
using AspNetCoreVideo.Data;
using AspNetCoreVideo.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreVideo.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly VideoDbContext _dbContext;
      
        public IndexModel(VideoDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public void OnGet()
        {
          
                               
        }
    }
}
