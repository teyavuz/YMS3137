using NtierEcommerce.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierEcommerce.MODEL.Map
{
    public class OrderDetailMap:BaseMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("OrderDetails");
        }
    }
}
