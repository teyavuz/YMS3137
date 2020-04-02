using MVCCustomTheme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCustomTheme.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            ViewBag.CustomerCount = db.Customers.Count();
            ViewBag.OrderCount = db.Orders.Count();
            ViewBag.ProductCount = db.Products.Count();
            ViewBag.TotalRevenue = db.Order_Details.Sum(x => x.Quantity * x.UnitPrice);
            ViewBag.Orders = db.Orders.OrderByDescending(x => x.OrderDate).Take(10).ToList();
            return View();
        }
    }
}