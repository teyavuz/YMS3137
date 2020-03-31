using MVCHtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHtmlHelpers.Controllers
{
    public class TextBoxController : Controller
    {
        // GET: TextBox
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonDetail()
        {
            Person person = new Person();
            person.ID = 1;
            person.Name = "Fatih";
            person.LastName = "Günalp";
            return View(person);
        }

        public ActionResult TextBoxFor()
        {
            Person person = new Person();
            person.ID = 1;
            person.Name = "Fatih";
            person.LastName = "Günalp";
            return View(person);
        }
    }
}