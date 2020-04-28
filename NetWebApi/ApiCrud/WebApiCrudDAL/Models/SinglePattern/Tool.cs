using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCrudDAL.Models.SinglePattern
{
    public class Tool
    {
        private static NorthwindEntities dbInstance;
        public static NorthwindEntities DbInstance
        {
            get
            {
                if (dbInstance == null)
                    dbInstance = new NorthwindEntities();
                return dbInstance;
            }
        }
    }
}