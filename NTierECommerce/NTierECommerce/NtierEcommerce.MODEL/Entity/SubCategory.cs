using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierEcommerce.MODEL.Entity
{
    public class SubCategory
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryID { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
