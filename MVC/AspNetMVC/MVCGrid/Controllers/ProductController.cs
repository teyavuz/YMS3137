using MVCGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGrid.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            //Nuget Package => Grid.MVC
            return View(db.Products.ToList());
        }
    }
}