using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeServiceV3.Controllers
{

    public class EmployeesController : ApiController
    {
        [Authorize]
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDB1Entities entities = new EmployeeDB1Entities())
            {
                return entities.Employees.ToList();
            }   
        }
    }
}
