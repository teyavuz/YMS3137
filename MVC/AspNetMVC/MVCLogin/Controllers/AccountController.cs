using MVCFilters.Models.Context;
using MVCLogin.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;//Cookie kullanabilmek için bu kütüphaneye ihtiyacımız var.

namespace MVCLogin.Controllers
{
    public class AccountController : Controller
    {
        AppDbContext db = new AppDbContext();
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = db.AppUsers.FirstOrDefault(x => x.UserName == loginVM.UserName && x.Password == loginVM.Password);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, true);//false tanımlanırsa browser kapanınca silinir(cookie hatırlamaz).
                    return RedirectToAction("Index");

                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}