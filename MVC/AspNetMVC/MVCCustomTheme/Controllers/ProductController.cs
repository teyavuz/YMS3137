using MVCCustomTheme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCustomTheme.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View(db.Products.OrderByDescending(x => x.ProductID).ToList());
            //return View(db.Products.Take(10).ToList());
        }

        public ActionResult Add()
        {
            ViewBag.Categories = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.Suppliers = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product, string Categories, string Suppliers)
        {
            product.SupplierID = Convert.ToInt32(Suppliers);
            product.CategoryID = Convert.ToInt32(Categories);
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}