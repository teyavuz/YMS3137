using NetCoreNorthwind.BLL.Abstract;
using NetCoreNorthwind.DAL.Model;
using NetCoreNorthwind.DAL.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreNorthwind.BLL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly NorthwindContext northwindContext;

        public ProductRepository(NorthwindContext northwindContext)
        {
            this.northwindContext = northwindContext;
        }
        public List<Products> GetAllProducts()
        {
            return northwindContext.Products.ToList();
        }
    }
}
