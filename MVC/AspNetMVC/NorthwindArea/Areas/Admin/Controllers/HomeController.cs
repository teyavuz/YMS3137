
using NorthwindArea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindArea.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        FacebookDBEntities db = new FacebookDBEntities();
        public ActionResult Index()
        {
            ViewBag.Users = db.Users.ToList();
            ViewBag.Photos = db.Photos.ToList();
            return View();
        }
    }
}