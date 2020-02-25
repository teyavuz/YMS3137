using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CodeFirstSamples.ORM.Entity.OneToMany
{
    public class Category
    {
        //bir kategorinin birden fazla ürünü olur.
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }


        //Mapping
        public List<Product> Products { get; set; }
    }
}
