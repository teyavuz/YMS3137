using MVCFilters.Models.Context;
using MVCFilters.Models.Entity;
using MVCFilters.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilters.Controllers
{
    public class LoginController : Controller
    {
        AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginVM userVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = db.AppUsers.FirstOrDefault(x => x.Password == userVM.Password && x.UserName == userVM.UserName);
                if (user != null)
                {
                    Session["login"] = user;
                    return RedirectToAction("Profile", "User");
                }
                else
                {
                    TempData["Result"] = "Kullanıcı bulunamadı";
                }

            }

            return View();
        }
    }
}