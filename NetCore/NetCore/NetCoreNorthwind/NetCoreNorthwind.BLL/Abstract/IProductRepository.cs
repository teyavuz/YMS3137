using System;
using System.Collections.Generic;
using System.Text;
using NetCoreNorthwind.DAL.Model;

namespace NetCoreNorthwind.BLL.Abstract
{
    public interface IProductRepository
    {
        List<Products> GetAllProducts();

    }
}
