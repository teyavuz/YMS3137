using NorthwindArea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindArea.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        FacebookDBEntities db = new FacebookDBEntities();
        public ActionResult Details(int id)
        {
            UserDetail userDetail = db.UserDetails.Find(id);
            return View(userDetail);
        }
    }
}