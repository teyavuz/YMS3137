﻿using NTierNorthwindProject.DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierNorthwindProject.BLL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        NorthwindEntities db = new NorthwindEntities();
        public void Add(Product item)
        {
            db.Products.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Product SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
