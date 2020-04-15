using NetCoreEntityFramework.Models.Abstract;
using NetCoreEntityFramework.Models.Context;
using NetCoreEntityFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEntityFramework.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext context;

        public ProductRepository(AppDbContext context)
        {
            this.context = context;
        }
        public List<Product> Products => context.Products.ToList();

        public Product GetByID(int id)
        {
           return context.Products.Find(id);
        }

        public bool InsertProduct(Product product)
        {
            context.Products.Add(product);
            if (context.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}

