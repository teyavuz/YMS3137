using NtierEcommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierEcommerce.MODEL.Map
{
    public class ProductMap:BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("Products");

            HasRequired(x => x.SubCategory)
                .WithMany(x => x.Products).HasForeignKey(x => x.SubCategoryID);

        }
    }
}
