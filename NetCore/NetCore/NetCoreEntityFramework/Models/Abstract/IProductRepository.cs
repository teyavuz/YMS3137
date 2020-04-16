using NetCoreEntityFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEntityFramework.Models.Abstract
{
    public interface IProductRepository
    {
        //liste olarak döndürme
        List<Product> Products { get; }
        //tekil döndürme
        Product GetByID(int id);
        //ekleme
        bool InsertProduct(Product product);
        //Güncelleme
        bool Update(Product product);
        //Silme
        bool Delete(int id);
    }
}
