﻿using MVCDataTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataTransfer.Controllers
{
    public class HomeController : Controller
    {
       //Data Transfer

            /*
             ViewBag & ViewData

            Küçük boyutlardaki verileri Controller'dan view sayfasına taşınmasını sağlayan yapılardır.
            ViewData MVC 2 ile gelen bir özelliktir.
            ViewBag MVC 3 ile gelen bir özelliktir. Aynı zamanda runtime sırasında oluşan dinamik bir yapıdır.

            TempData

            Basit bir çalışma mantığına sahiptir. ViewBag ve ViewData ile aynı işi yapar. TempDatayı viewbag ve ViewDatadan ayıran en büyük özellik bir sonraki sayfaya taşınan verilerin daha sonra tekrardan başka bir sayfadan kullanımak istenilmesidir.

             
             */
        public ActionResult Index()
        {
            List<Category> categories = new List<Category>()
            {
                new Category{ID=1,CategoryName="Beverages",Description="Soft drinks, coffee"},
                new Category{ID=2,CategoryName="Condiments",Description="Soft drinks, coffee"},
                new Category{ID=3,CategoryName="Confections",Description="Soft drinks, coffee"},
                new Category{ID=4,CategoryName="Dairy Products",Description="Soft drinks, coffee"}
            };

            ViewData["KategoriListesi"] = categories;
            ViewBag.KategoriListesi = categories;
            TempData["KategoriListesi"] = categories;
            return View();
        }

        public ActionResult Category()
        {
            return View();
        }


    }
}