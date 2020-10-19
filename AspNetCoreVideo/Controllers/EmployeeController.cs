using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    [Route(template:"[controller]/[action]/{id?}")]
    public class EmployeeController : Controller
    {
        [Route(template: "/Employee")]
        [Route(template: "/Employee/Index")]
        public ContentResult Index()
        {
            return Content("Default Employee Controller Route");
        }
        public ContentResult Name()
        {
            return Content("The name of the Developer is Tuse");
        }
    }
}
