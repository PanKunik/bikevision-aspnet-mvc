﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bikevision.Models
{
    public class Cart
    {
        // \\//  Add Product model
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal NewPrice { get; set; }
        public string Options { get; set; }
        public Cart(Item item, int quantity, string options = "", decimal price = 0)
        {
            Item = item;
            Quantity = quantity;
            NewPrice = price;
            Options = options;
        }
    }
}