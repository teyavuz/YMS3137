using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.CustomHelpers;
using MVC.Models;
using MVC.Models.CartModel;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View(productService.GetActive());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddToCart(Guid id)
        {

            Cart cartSession = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart") == null ? new Cart() : SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart");
            var product = productService.GetById(id);
            CartItem cartItem = new CartItem();
            cartItem.ID = product.ID;
            cartItem.Name = product.ProductName;
            cartItem.Price = product.Price;
            cartItem.ImagePath = product.ImagePath;
            cartSession.AddItem(cartItem);
            SessionHelper.SetProductJson(HttpContext.Session, "cart", cartSession);


            return RedirectToAction("Index");
        }

        public IActionResult MyCart()
        {
            if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart") != null)
            {
                Cart c = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart");
                return View(c.MyCart);
            }
            //Todo: Sepetiniz şu an boş ibaresini ziyaretçiye gösterin.
            return RedirectToAction("Index");

        }
    }
}
