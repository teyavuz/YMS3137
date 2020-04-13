using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreIntroduction.Models;

namespace NetCoreIntroduction.Controllers
{
    public class CategoryController : Controller
    {
        

        public IActionResult Index()
        {
            List<Category> categories = Category.categories;
            return View(categories);
        }

        public ActionResult GetCategory(int CategoryID)
        {
            var category = Category.categories.Where(x => x.CategoryID == CategoryID);
            return View(category);
        }
    }
}