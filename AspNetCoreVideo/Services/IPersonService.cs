using AspNetCoreVideo.AspNetCoreVideo.Models;
using AspNetCoreVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public interface IPersonService
    {
        Person GetEmployeeById(int id);
    }
}
