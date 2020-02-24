using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CodeFirst.ORM.Entity
{
   public class Product:BaseEntity
    {
        //public int ID { get; set; }
        //public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

    }
}
