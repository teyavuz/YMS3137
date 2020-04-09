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
    }
}