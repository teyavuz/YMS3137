using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreNorthwind.Models.Context;
using NetCoreNorthwind.Models.ViewModels;

namespace NetCoreNorthwind.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly NorthwindContext northwindContext;

        public ProductCategoryController(NorthwindContext northwindContext)
        {
            this.northwindContext = northwindContext;
        }
        public IActionResult Index()
        {
            ProductCategoryVM productCategoryVM = new ProductCategoryVM();
            productCategoryVM.Products = northwindContext.Products.ToList();
            productCategoryVM.Categories = northwindContext.Categories.ToList();
            return View(productCategoryVM);
        }

        public IActionResult ProductsWithCategory(int id)
        {
            var products = northwindContext.Products.Where(x => x.CategoryId == id).ToList();
            return View(products);
        }
    }
}