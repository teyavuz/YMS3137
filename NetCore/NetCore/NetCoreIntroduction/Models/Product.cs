using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreIntroduction.Models
{
    public class Product
    {
        public static List<Product> products = new List<Product>()
        {
            new Product{ProductID=1, ProductName="Chai",UnitPrice=18m,UnitsInStock=10,CategoryID=1},
            new Product{ProductID=2, ProductName="Chang",UnitPrice=15m,UnitsInStock=10,CategoryID=2},
            new Product{ProductID=1, ProductName="Tofu",UnitPrice=18m,UnitsInStock=10,CategoryID=2}
        };
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int CategoryID { get; set; }

    }
}
