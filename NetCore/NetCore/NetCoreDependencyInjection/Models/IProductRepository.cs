using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDependencyInjection.Models
{
    public interface IProductRepository
    {
        List<Product> Products { get; }
    }
}
