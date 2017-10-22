using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F_Market.Models
{
    public class SupplierProduct
    {
        [Key]
        public int SupplierProductId { get; set; }

        public int SupplierId { get; set; }
        public int ProductId { get; set; }

        //Para crear relaciones entre tablas.
        public virtual Supplier Supplier { get; set; }

        public virtual Product Product { get; set; }
    }
}