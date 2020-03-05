using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierEcommerce.MODEL.Entity
{
    public class Order
    {
        public Order()
        {
            
            OrderDetails = new List<OrderDetail>();
        }
        public int ID { get; set; }
        public virtual AppUser AppUser { get; set; }
        public bool Confirmed { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }


    }
}
