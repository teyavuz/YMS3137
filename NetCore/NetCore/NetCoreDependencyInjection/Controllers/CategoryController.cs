using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreDependencyInjection.Models.Abstract;

namespace NetCoreDependencyInjection.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepo;

        public CategoryController(ICategoryRepository _categoryRepo)
        {
            categoryRepo = _categoryRepo;
        }
        public IActionResult Index()
        {
            return View(categoryRepo.Categories());
        }
    }
}