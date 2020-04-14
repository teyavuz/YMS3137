using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreDependencyInjection.Models;

namespace NetCoreDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
       

        //ProductRepository repository = new ProductRepository();
        private IProductRepository repository;
        public HomeController(IProductRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}