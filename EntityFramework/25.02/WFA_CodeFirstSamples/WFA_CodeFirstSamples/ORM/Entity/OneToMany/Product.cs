using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CodeFirstSamples.ORM.Entity.OneToMany
{
    public class Product
    {
        //bir ürünün bir kategorisi olur.
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        public int CategoryId { get; set; }

        //Mapping
        //Lazy Load Nedir?
        public virtual Category Category { get; set; }
    }
}
