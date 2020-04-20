using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;//UserManager
using Microsoft.AspNetCore.Mvc;
using NetCoreIdentity.Models.Entity;
using NetCoreIdentity.Models.ViewModels;

namespace NetCoreIdentity.Controllers
{
    public class UserController : Controller
    {
        //UserManager Sınıfı;
        /*
         uygulama üzerinde a'dan z'ye kullanıcı yönetimini gerçekleştirmemizi sağlayan sınıftır. UseManager sınıfı hangi kullanıcı türünü yöneteceğini generic özelliğinden alır.
             */
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public UserController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(AppUserVM appUserVM)
        {
            if (ModelState.IsValid)
            {
                AppUser newUser = new AppUser()
                {
                    UserName = appUserVM.UserName,
                    Email = appUserVM.Email
                };

                var result =await userManager.CreateAsync(newUser, appUserVM.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                //eğer farklı bir hata alınırsa alınan hatayı ModelState içerisine eklerek bütün hataları List halinde görebilmemiz için aşağıdaki kodu dahil ediyoruz.
                else
                {
                    result.Errors.ToList().ForEach(x => ModelState.AddModelError(x.Code, x.Description));
                }
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM appUserVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user =await userManager.FindByNameAsync(appUserVM.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();

                    var result = await signInManager.PasswordSignInAsync(user, appUserVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Profile", user);
                    }
                }
            }
            return View();
        }

        public IActionResult Profile(AppUser user)
        {
            return View(user);
        }
    }
}