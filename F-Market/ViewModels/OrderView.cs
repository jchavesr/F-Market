using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using F_Market.Models;

namespace F_Market.ViewModels
{
    public class OrderView
    {
        public Customer Customer { get; set; }

        public List<ProductOrder> Products { get; set; }
    }
}