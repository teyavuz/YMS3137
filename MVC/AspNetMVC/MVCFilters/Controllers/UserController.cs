using MVCFilters.Filters;
using MVCFilters.Models.Context;
using MVCFilters.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilters.Controllers
{
    public class UserController : Controller
    {
        
        [AuthFilter]
        public ActionResult Profile()
        {
            var user = Session["login"] as AppUser;
            return View(user);
        }
    }
}