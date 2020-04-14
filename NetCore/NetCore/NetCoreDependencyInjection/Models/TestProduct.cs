using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDependencyInjection.Models
{
    public class TestProductRepository:IProductRepository
    {


        public List<Product> Products => new List<Product>()
        {
            new Product{ProductID=1,ProductName="Test",Category="Test"}
        };
    }
}
