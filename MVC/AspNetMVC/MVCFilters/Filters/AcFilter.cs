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
            Log log = new Log();
            log.UserName = "admin";
            log.LogDate = DateTime.Now;
            log.Description = log.UserName + " tarafından giriş yaptı.";
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            db.Logs.Add(log);
            db.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log log = new Log();
            log.UserName = "admin";
            log.LogDate = DateTime.Now;
            log.Description = log.UserName + " tarafından giriş yapılıyor.";
            log.ActionName = filterContext.ActionDescriptor.ActionName;
            log.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            db.Logs.Add(log);
            db.SaveChanges();
        }
    }
}