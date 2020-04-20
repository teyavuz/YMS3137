using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;//UserManager
using Microsoft.AspNetCore.Mvc;
using NetCoreIdentity.Models.Entity;

namespace NetCoreIdentity.Controllers
{
    public class UserController : Controller
    {
        //UserManager Sınıfı;
        /*
         uygulama üzerinde a'dan z'ye kullanıcı yönetimini gerçekleştirmemizi sağlayan sınıftır. UseManager sınıfı hangi kullanıcı türünü yöneteceğini generic özelliğinden alır.
             */
        private readonly UserManager<AppUser> userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}