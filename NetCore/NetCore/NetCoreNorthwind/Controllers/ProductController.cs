using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreNorthwind.Models.Context;

namespace NetCoreNorthwind.Controllers
{
    public class ProductController : Controller
    {
        private readonly NorthwindContext northwindContext;

        public ProductController(NorthwindContext northwindContext)
        {
            this.northwindContext = northwindContext;
        }
        public IActionResult Index()
        {
            return View(northwindContext.Products.ToList());
        }
    }
}