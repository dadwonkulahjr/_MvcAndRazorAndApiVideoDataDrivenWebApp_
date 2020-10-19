using AspNetCoreVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public class HardCodedComaxEmployeeService : IComaxEmployeeService
    {
        private readonly List<ComaxStaffsOnly> _comaxStaffsOnly;
        public HardCodedComaxEmployeeService()
        {
            _comaxStaffsOnly = new List<ComaxStaffsOnly>()
            {
                new ComaxStaffsOnly(staffId:101,
                firstName:"Dad",lastName:"Wonkulah",gender:"Male"),
                new ComaxStaffsOnly(staffId:102,
                firstName:"Mohammed",lastName:"Jalloh",gender:"Male"),
                new ComaxStaffsOnly(staffId:103,
                firstName:"Arnold",lastName:"Smith",gender:"Male"),
                new ComaxStaffsOnly(staffId:104,
                firstName:"Romeo",lastName:"Davies",gender:"Male"),
                new ComaxStaffsOnly(staffId:105,
                firstName:"Dexter",lastName:"Maxwell",gender:"Male"),
            };
        }
        public IEnumerable<ComaxStaffsOnly> GetAllComaxStaffs()
        {
            return _comaxStaffsOnly.ToList();
        }
    }
}
