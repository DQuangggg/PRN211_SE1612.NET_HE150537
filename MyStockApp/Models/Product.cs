﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MyStockApp.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitStock { get; set; }
        public int CategoryId { get; set; }

        public virtual Catgory Category { get; set; }
    }
}
