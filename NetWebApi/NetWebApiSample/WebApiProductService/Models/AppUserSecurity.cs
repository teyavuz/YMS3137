using NetWebApiProductDataAccess.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProductService.Models
{
    public class AppUserSecurity
    {
        public static bool Login(string username, string password)
        {
            AppDbContext db = new AppDbContext();
            return db.AppUsers.Any(x => x.UserName == username && x.Password == password);
        } 
    }
}