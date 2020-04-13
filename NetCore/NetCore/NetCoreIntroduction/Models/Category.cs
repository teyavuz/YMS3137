using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIntroduction.Models
{
    public class Category
    {

        public static List<Category> categories = new List<Category>()
        {
            new Category{CategoryID=1,CategoryName="Beverages"},
            new Category{CategoryID=2,CategoryName="Condiments"},
            new Category{CategoryID=3,CategoryName="Diary Products"}

        };
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }


    }
}
