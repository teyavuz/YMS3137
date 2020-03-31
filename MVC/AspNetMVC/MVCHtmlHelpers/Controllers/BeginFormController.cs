using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHelpers.Controllers
{
    public class BeginFormController : Controller
    {
        // GET: BeginForm
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            return View();
        }
    }
}