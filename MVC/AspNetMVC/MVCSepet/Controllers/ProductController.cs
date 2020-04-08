using MVCSepet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSepet.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public ActionResult AddToCart(int id)
        {
            //Sepete ait Session oluşturma
            //Cart c;
            //if (Session["scart"] == null)
            //{
            //    c = new Cart();
            //}
            //else
            //{
            //   c= Session["scart"] as Cart;
            //}

            //ilk etapta Cart tipinde bir session oluşturuyoruz. Fakat oluştuırmadan önce daha önce Session["scart"] isme ait bir session var mı yok mu diye kontroller ediyoruz. 
            Cart c = Session["scart"] == null ? new Cart() : Session["scart"] as Cart;
            //Id üzerinden yakladığımız id'i northwind içerisinde bulunan ürünlerde aratarak eklenecekUrun içerisine aktarıyoruz.
            Product eklenecekUrun = db.Products.Find(id);
            //cartitem classından bir instance alarak aktarmış olduğumuz eklenecekUrun içerisindeki bilgileri CartItem içerisine dolduruyoruz.
            CartItem ci = new CartItem();
            ci.ID = eklenecekUrun.ProductID;
            ci.Name = eklenecekUrun.ProductName;
            ci.Price = eklenecekUrun.UnitPrice;
            //daha önce oluşturduğumuz c isim (Cart)'a doldurmuş olduğumuz cartitem'i ekliyoruz.
            c.AddItem(ci);
            //eklenen cart daha sonra tanımlanan Session içerisine aktarılıoyor.
            Session["scart"] = c;
            //eklenen ürünü index'te göstermek için TempData tanımlandı.
            TempData["cart"] = $"{eklenecekUrun.ProductName} sepete eklendi";
            return RedirectToAction("Index");
        }

        public ActionResult MyCart()
        {
            if (Session["scart"] != null)
            {
                Cart c = Session["scart"] as Cart;
                return View(c.myCart);
            }
            else
            {
                TempData["emptyCart"] = "Sepetiniz Boş";
                return RedirectToAction("Index");
            }
            
        }
    }
}