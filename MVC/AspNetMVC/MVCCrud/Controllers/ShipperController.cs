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

        //Nakliyeci Güncelleme

        //Nakliyeci Silme
    }
}