using MVCCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrud.Controllers
{
    public class ShipperController : Controller
    {
        //Database
        NorthwindEntities db = new NorthwindEntities();

        // Nakliyecilerin Listelenmesi
        public ActionResult Index()
        {
            return View(db.Shippers.ToList());
        }

        //Nakliyeci Ekleme

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Shipper shipper)
        {
            if (ModelState.IsValid)
            {
                db.Shippers.Add(shipper);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Bilgi"] = "Model Boş Tanımlanamaz!";
                return View();
            }
            
        }


        //Nakliyeci Güncelleme
        public ActionResult Update(int id)//101
        {
            var shipper = db.Shippers.Find(id);
            if (shipper == null)
            {
                TempData["Bilgi"] = "Nakliyeci bulunamadı";
            }
            return View(shipper);
        }

        [HttpPost]
        public ActionResult Update(Shipper shipper)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shipper).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Bilgi"] = "Model Boş Tanımlanamaz!";
                return View();
            }
            
        }
        //Nakliyeci Silme
        public ActionResult Delete(int id)
        {
            var shipper = db.Shippers.Find(id);
            db.Shippers.Remove(shipper);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}