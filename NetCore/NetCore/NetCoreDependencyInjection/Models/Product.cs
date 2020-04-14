using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDependencyInjection.Models
{
    public class Product
    {
        //public static List<Product> products = new List<Product>()
        //{
        //    new Product{ProductID=1,ProductName="Chai",UnitPrice=18m, Category="Beverages"}
        //};
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string Category { get; set; }

    }
}
