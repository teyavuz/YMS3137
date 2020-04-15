using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreEntityFramework.Models.Abstract;
using NetCoreEntityFramework.Models.Entity;

namespace NetCoreEntityFramework.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(productRepository.Products);
        }

        public IActionResult Details(int id)
        {
           var product= productRepository.GetByID(id);
            return View(product);
        }

        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Product model)
        {
           bool state= productRepository.InsertProduct(model);
            if (state)
            {
                TempData["success"] = $"{model.ProductName} inserted successfully!";
            }
            else
            {
                TempData["error"] = "an error occurred!";
            }
            return RedirectToAction("Index");
        }
    }
}