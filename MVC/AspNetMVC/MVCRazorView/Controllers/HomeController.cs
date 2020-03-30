using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRazorView.Controllers
{
    public class HomeController : Controller
    {
        //View Engine Nedir?
        /*
         Razor
         Web Form
         Spark
         Nhalm
             */

        //Razor View Engine

            /*
             Asp.Net MVC 3 ile hayatımıza giren Razor View Engine view engine lar arasında en sıklıkla kullanılanıdır. Html ile C# kodlarını iç içe yazmamıza olanaj sağlar.
             */

        public ActionResult Index()
        {
            return View();
        }
    }
}