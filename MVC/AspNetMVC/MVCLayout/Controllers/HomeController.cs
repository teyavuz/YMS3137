
using MVCLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLayout.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            //Category gönderilecek.
            return View(db.Products.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Service()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult _CategoryPartial()
        {
            return PartialView(db.Categories.ToList());
        }
    }
}