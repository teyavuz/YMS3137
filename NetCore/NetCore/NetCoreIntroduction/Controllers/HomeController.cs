using Microsoft.AspNetCore.Mvc;
using NetCoreIntroduction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIntroduction.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            Employee employee = new Employee();
            employee.FirstName = "Nancy";
            employee.LastName = "Davoilo";
            return View(employee);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
