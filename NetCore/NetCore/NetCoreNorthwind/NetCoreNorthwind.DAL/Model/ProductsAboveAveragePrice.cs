﻿using System;
using System.Collections.Generic;

namespace NetCoreNorthwind.DAL.Model
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
