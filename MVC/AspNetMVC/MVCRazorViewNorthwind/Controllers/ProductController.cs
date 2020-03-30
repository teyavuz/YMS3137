using MVCRazorViewNorthwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRazorViewNorthwind.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            
            return View(db.Products.ToList());
        }

        public ActionResult Detail(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.ProductID == id);
            return View(product);
        }

    }
}