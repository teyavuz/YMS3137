using NtierEcommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierEcommerce.MODEL.Map
{
    public class SubCategoryMap:BaseMap<SubCategory>
    {
        public SubCategoryMap()
        {
            ToTable("SubCategories");

            HasMany(x => x.Products)
                .WithRequired(x => x.SubCategory)
                .HasForeignKey(x => x.SubCategoryID);
        }
    }
}
