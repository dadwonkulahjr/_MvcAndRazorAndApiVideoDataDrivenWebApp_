using AspNetCoreVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public interface IComaxEmployeeService
    {
        IEnumerable<ComaxStaffsOnly> GetAllComaxStaffs();
    }
}
