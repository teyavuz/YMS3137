using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Identity;
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
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;
        private readonly IOrderService orderService;

        public HomeController(ILogger<HomeController> logger, IProductService productService, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IOrderService orderService)
        {
            _logger = logger;
            this.productService = productService;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.orderService = orderService;
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
        
        public async Task<IActionResult> CompleteCart()
        {
            
            Cart cart= SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "cart");
            Order order = new Order();
            if (signInManager.IsSignedIn(User))
            {
                var user =await userManager.GetUserAsync(User);
                order.AppUser = user;
                order.Confirmed = false;
            }
            else
            {
                return Redirect("/Member/Account/Login");
            }
            //Todo: alışverişi tamamlama işlemi yapılacak.

            //alışverişi tamamla butonuna tıklandığında ilk olarak Order nesnenin bir örneğini alarak oturum açan kullanıcı bilgileri Appuser içerisine aktarılacak ardından OrderDetail nesnenin bir örneği alınarak OrderDetail içerisinde bulunan Product'a myCart içerisindeki ürünler eklenecek.

            foreach (var item in cart.MyCart)
            {
                OrderDetail orderDetail = new OrderDetail();
                var product = productService.GetById(item.ID);
                //product.ProductName = item.Name;
                //product.Quantity = item.Quantity;
                //product.Price = item.Price;
                orderDetail.Product = product;
                order.OrderDetails.Add(orderDetail);
            }
            order.MasterId = 15;
            orderService.Add(order);
            return View(order);
        }
    }
}
