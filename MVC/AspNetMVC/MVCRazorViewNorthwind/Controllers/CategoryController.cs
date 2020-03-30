using MVCRazorViewNorthwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRazorViewNorthwind.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }

        public ActionResult Detail(int id)
        {
            var category = db.Categories.FirstOrDefault(x => x.CategoryID == id);
            return View(category);
        }

        public ActionResult Delete(int id)
        {
            var category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

