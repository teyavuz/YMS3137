using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRazorViewNorthwind.Controllers
{
    public class DataController : Controller
    {
        //eğer View içerisinden bir veriyi göndermek istiyorsak o view ismine ait HttpPost attribute tanımlamamız gerekmektedir. Örn. Aşağıdaki gibi.

        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        //Post: Data
        [HttpPost]
        public ActionResult Index(string name, string surname)
        {
            
            return View();
        }

    }
}