using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreIntroduction.Models;

namespace NetCoreIntroduction.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetProduct(int ProductId)
        {
            return View(Product.products.FirstOrDefault(x => x.ProductID == ProductId));
        }

        public ActionResult GetProducts(int categoryId)
        {
            return View(Product.products.Where(x => x.CategoryID == categoryId).ToList());
        }
    }
}