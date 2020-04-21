using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        public IActionResult Login(string ReturnUrl)
        {
            TempData["url"] = ReturnUrl;
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

                    var result = await signInManager.PasswordSignInAsync(user, appUserVM.Password, appUserVM.IsPersistent, false);
                    if (result.Succeeded)
                    {
                        return Redirect(TempData["url"].ToString());
                    }
                }
            }
            return View();
        }

        public async Task<ActionResult> ResetPassword(string id)
        {
            if (id != null)
            {
                var user =await userManager.FindByIdAsync(id);
                if (user != null)
                {
                   await userManager.UpdateSecurityStampAsync(user);
                    await signInManager.SignOutAsync();
                    await signInManager.SignInAsync(user, true);
                    ResetPasswordVM resetPasswordVM = new ResetPasswordVM()
                    {
                        UserName = user.UserName,
                        Email = user.Email
                    };

                    return View(resetPasswordVM);
                }
            }
            return RedirectToAction("Login");
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        {
            if (ModelState.IsValid)
            {
                //modelde yakaladığımız reserPassword içerisindeki username veritabanında var mı yok mu kontrol ederek user içerisine bilgileri alıyoruz.
                AppUser user = await userManager.FindByNameAsync(resetPasswordVM.UserName);
                if (user != null)
                {
                    //kullanıcı dolu olarak geldiyse kullanmış olduğu şifre veritabanındaki şifre ile aynı mı?
                    if(await userManager.CheckPasswordAsync(user, resetPasswordVM.OldPassword))
                    {
                        //resetPasswordVM içerisinde yakalamış olduğumuz yeni şifreyi kullanıcının eski şifresi ile değiştiriyoruz.
                        var result = await userManager.ChangePasswordAsync(user, resetPasswordVM.OldPassword, resetPasswordVM.NewPassword);
                        if (result.Succeeded)
                        {
                            await userManager.UpdateSecurityStampAsync(user);
                            await signInManager.SignOutAsync();
                            await signInManager.SignInAsync(user, true);
                            return RedirectToAction("Index");
                        }
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
           await signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult Profile()
        {
            return View();
        }
    }
}