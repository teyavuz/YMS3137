using MVCCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrud.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            ViewBag.Categories = new SelectList(db.Categories, "CategoryID", "CategoryName");
            return View(db.Products.ToList());
        }
    }
}