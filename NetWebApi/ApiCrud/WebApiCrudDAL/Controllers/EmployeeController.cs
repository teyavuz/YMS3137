using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCrudDAL.Models;
using WebApiCrudDAL.Models.SinglePattern;
using WebApiCrudDAL.Models.ViewModels;

namespace WebApiCrudDAL.Controllers
{
    public class EmployeeController : ApiController
    {
        NorthwindEntities db = Tool.DbInstance;

        public IEnumerable<EmployeeVM> GetEmployees()
        {
            return db.Employees.Select(x => new EmployeeVM
            {
                ID=x.EmployeeID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Title = x.Title,
                City = x.City,
                Country = x.Country
            }).ToList();
        }

        public IHttpActionResult AddEmployee(Employee model)
        {
            db.Employees.Add(model);
            db.SaveChanges();
            return Ok(GetEmployees());
        }

        public IHttpActionResult RemoveEmployee(int id)
        {
            db.Employees.Remove(db.Employees.Find(id));
            db.SaveChanges();
            return Ok(GetEmployees());
        }

        public IHttpActionResult Update(Employee employee)
        {
            Employee updated = db.Employees.Find(employee.EmployeeID);
            db.Entry(updated).CurrentValues.SetValues(employee);
            db.SaveChanges();
            return Ok(GetEmployees());
        }

        public List<EmployeeVM> SearchEmployee(string item)
        {
            return db.Employees.Where(x => x.FirstName.Contains(item)).Select(x => new EmployeeVM
            {
                ID = x.EmployeeID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Title = x.Title,
                City = x.City,
                Country = x.Country
            }).ToList();
        }
    }
}
