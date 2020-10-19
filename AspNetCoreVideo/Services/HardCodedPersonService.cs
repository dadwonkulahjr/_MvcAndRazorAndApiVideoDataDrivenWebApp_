using AspNetCoreVideo.AspNetCoreVideo.Models;
using AspNetCoreVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public class HardCodedPersonService : IPersonService
    {
        private readonly List<Person> _employeeList;
        public HardCodedPersonService()
        {
            _employeeList = new List<Person>()
            {
                new Person(personId:101, firstName:"Prince", lastName:"Smith",
                salary:50000m),
                new Person(personId:102, firstName:"Pricess", lastName:"Roberts",
                salary:6000m),
                new Person(personId:103, firstName:"Mike", lastName:"Pin",
                salary:5000m),
                new Person(personId:104, firstName:"Beatrice", lastName:"Holder",
                salary:3500m)
            };
        }
        public Person GetEmployeeById(int id)
        {
            return _employeeList.FirstOrDefault(p => p.PersonId == id);
        }
    }
}
