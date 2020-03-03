using NorthwindSingleton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindSingleton.Tool
{
    public class Singleton
    {
        private Singleton() { }

        private static NorthwindEntities _db;

        public static NorthwindEntities db
        {
            get
            {
                if (_db == null)
                    _db = new NorthwindEntities();
                return _db;
            }
        }


    }
}
