using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreNorthwind.Models.ViewModels
{
    public class ProductCategoryVM
    {
        public List<Products> Products { get; set; }
        public List<Categories> Categories { get; set; }
    }
}
