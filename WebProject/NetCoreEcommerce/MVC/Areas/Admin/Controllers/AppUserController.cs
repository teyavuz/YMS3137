using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.Areas.Admin.Models.ViewModels;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public AppUserController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        public ActionResult Index()
        {
            return View(userManager.Users);
        }

        // GET: AppUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AppUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppUser/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AppUserVM appUserVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = appUserVM.UserName,
                    Email = appUserVM.Email
                };
                var result = await userManager.CreateAsync(user, appUserVM.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        // GET: AppUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AppUser/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppUser/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}