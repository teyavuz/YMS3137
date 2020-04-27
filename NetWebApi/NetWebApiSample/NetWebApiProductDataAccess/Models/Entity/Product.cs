﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetWebApiProductDataAccess.Models.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitsInStock { get; set; }

    }
}