using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierEcommerce.MODEL.Entity
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public decimal UnitPrice { get; set; }
        public short? Quantity { get; set; }
    }
}
