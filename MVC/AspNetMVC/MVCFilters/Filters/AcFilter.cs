using MVCFilters.Models.Context;
using MVCFilters.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilters.Filters
{
    public class AcFilter : FilterAttribute, IActionFilter
    {
        AppDbContext db = new AppDbContext();
        //herhangi bir class filter olarak kullanılabilmesi için FilterAttribute'den miras alması gerekmektedir.

           
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var user = filterContext.HttpContext.Session["login"] as AppUser;
           
            Log log = new Log();
            if (user == null)
            {
                log.UserName = "ziyaretçi";
            }
            else
            {
                log.UserName = user.UserName;
            }
            
            log.LogDate = DateTime.Now;
            log.Description = log.UserName + " tarafından giriş yaptı.";
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            db.Logs.Add(log);
            db.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = filterContext.HttpContext.Session["login"] as AppUser;
           
            Log log = new Log();
            if (user == null)
            {
                log.UserName = "ziyaretçi";
            }
            else
            {
                log.UserName = user.UserName;
            }
            
            log.LogDate = DateTime.Now;
            log.Description = log.UserName + " tarafından giriş yapılıyor.";
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            db.Logs.Add(log);
            db.SaveChanges();
        }
    }
}