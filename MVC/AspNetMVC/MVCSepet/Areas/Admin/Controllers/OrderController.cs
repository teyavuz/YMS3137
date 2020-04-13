using MVCSepet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSepet.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            var orders = db.Orders.Where(x => x.CustomerID == null & x.Employee == null).OrderByDescending(x=>x.OrderID).ToList();
            return View(orders);
        }

        public ActionResult OrderComplete(int id)
        {

            Order order = db.Orders.Find(id);
           
            Cart cart = Session["scart"] as Cart;
            Order_Detail order_Detail = new Order_Detail();
      
            foreach (var c in cart.myCart)
            {
                order_Detail.OrderID = id;
                if (db.Order_Details.Any(x => x.ProductID == c.ID))
                {
                    order_Detail.Quantity++;
                }
                order_Detail.Quantity = c.Quantity;
                order_Detail.UnitPrice = c.Price;
                db.Order_Details.Add(order_Detail);
                db.SaveChanges();
            }
           
            return View();
        }

    }
}