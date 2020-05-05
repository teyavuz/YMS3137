using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly UserManager<AppUser> userManager;

        public OrderController(IOrderService orderService, UserManager<AppUser> userManager)
        {
            this.orderService = orderService;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            ViewBag.Users = userManager.Users;
            return View(orderService.GettAll());
        }

      
    }
}