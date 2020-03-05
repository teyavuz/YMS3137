using NtierEcommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierEcommerce.MODEL.Map
{
    public class CategoryMap:BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("Categories");
            Property(x => x.Description).IsOptional();

            //Map
            HasMany(x => x.SubCategories)
                .WithRequired(x => x.Category).HasForeignKey(x => x.CategoryID);

        }
    }
}
