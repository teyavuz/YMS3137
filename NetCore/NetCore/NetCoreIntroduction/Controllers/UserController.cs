using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreIntroduction.Models;

namespace NetCoreIntroduction.Controllers
{
    public class UserController : Controller
    {

        //public ActionResult HtmlHelperSample()
        //{
        //    return View();
        //}
        public ActionResult HtmlHelperSample() => View();

        [HttpPost]
        public ActionResult HtmlHelperSample(User user)
        {
            return View();
        }

        public ActionResult TagHelperSample()
        {
            return View();
        }
    }
}