using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEntityFramework.Models.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        //stok alanını sonradan ekleyelim
        public short Stock { get; set; }

    }
}
