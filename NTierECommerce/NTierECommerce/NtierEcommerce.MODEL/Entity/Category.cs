using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtierEcommerce.MODEL.Entity
{
    public class Category
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }

        public virtual List<SubCategory> SubCategories { get; set; }

    }
}
