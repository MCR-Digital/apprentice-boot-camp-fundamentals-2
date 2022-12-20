using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Product
    {
        public int Cost { get; set; }
        public string Sku { get; set; }
        public int MultiBuy_amount { get; set; }
        public int MultiBuy_Discount { get; set; }

        public Product(int cost, string sku)
        {
            this.Cost = cost;
            this.Sku = sku;
        }

        public Product()
    }
}
