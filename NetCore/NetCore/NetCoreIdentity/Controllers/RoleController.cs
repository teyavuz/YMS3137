using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCoreIdentity.Models.Entity;

namespace NetCoreIdentity.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> roleManager;
        private readonly UserManager<AppUser> userManager;

        public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(roleManager.Roles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AppRole appRole)
        {
            if (ModelState.IsValid)
            {
              var result= await roleManager.CreateAsync(appRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "User");
                }
            }
            return View();
        }

        public async Task<IActionResult> AssignAdminRole(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            await userManager.AddToRoleAsync(user, "Administrator");
            return RedirectToAction("Index", "User");
        }

        public async Task<IActionResult> AssignUserRole(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            await userManager.AddToRoleAsync(user, "User");
            return RedirectToAction("Index", "User");
        }
    }
}