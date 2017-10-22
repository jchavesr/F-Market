using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace F_Market.Models
{
    public class ProductOrder:Product
    {
        public float Quantity { get; set; }

        public decimal Value {
            get { return Price * (decimal) Quantity; }
        }
    }
}