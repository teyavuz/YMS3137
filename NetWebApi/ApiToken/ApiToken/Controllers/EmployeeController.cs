using ApiToken.Models;
using ApiToken.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiToken.Controllers
{
   [Authorize]
    public class EmployeeController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();
        
        public IEnumerable<EmployeeVM> GetEmployees()
        {
            return db.Employees.Select(x => new EmployeeVM
            {
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();
        }
    }
}
