using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDependencyInjection.Models
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> Products => new List<Product>()
        {
            new Product{ProductID=1, ProductName="Chai",Category="Beveregas"},
            new Product{ProductID=2, ProductName="Kahve",Category="Beveregas"},
            new Product{ProductID=3, ProductName="Pizza",Category="Food"},
            new Product{ProductID=4, ProductName="Makarna",Category="Food"},
        };
    }
}
