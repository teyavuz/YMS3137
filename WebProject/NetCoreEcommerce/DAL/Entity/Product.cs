using DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class Product:CoreEntity
    {
        public decimal? Price { get; set; }
        public short? UnitsInStock { get; set; }
        public short Quantity { get; set; }
        public string ImagePath { get; set; }
        public string ProductName { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
