using MVCSepet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSepet.Controllers
{
    public class OrderController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetOrder()
        {
            return View(new Order { Freight=9.99m});
        }
        [HttpPost]
        public ActionResult GetOrder(Order order)
        {
      
            db.Orders.Add(order);
            db.SaveChanges();
            var orderId = db.Orders.OrderByDescending(x => x.OrderID).First().OrderID;
            TempData["order"] = $"{orderId} Nolu Siparişiniz oluşturulmuştur.";
            return RedirectToAction("Index");
        }
    }
}