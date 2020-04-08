using MVCAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MVCAjax.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View(db.Products.Take(5).ToList());
        }

        public ActionResult _ProductDetailPartial(int id)
        {
            //Nuget Package Manager console üzerinden "Microsoft.jQuery.Unobtrusive.Ajax" kütüphanesini projeye ekliyoruz.
            var product = db.Products.Find(id);
            Thread.Sleep(1000);
            return PartialView(product);
        }
    }
}