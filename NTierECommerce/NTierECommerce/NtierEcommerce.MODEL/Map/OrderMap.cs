using NtierEcommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierEcommerce.MODEL.Map
{
    public class OrderMap:BaseMap<Order>
    {
        public OrderMap()
        {
            ToTable("Orders");

            HasRequired(x => x.AppUser).WithMany(x => x.Orders);
        }
    }
}
