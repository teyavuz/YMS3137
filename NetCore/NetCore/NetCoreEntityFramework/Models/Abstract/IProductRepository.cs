using NetCoreEntityFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEntityFramework.Models.Abstract
{
    public interface IProductRepository
    {
        List<Product> Products { get; }
        Product GetByID(int id);
        bool InsertProduct(Product product);
        //Güncelleme
        //Silme
    }
}
