using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F_Market.Models
{
    public class Product
    {
        //Data annotation
        [Key]
        public int ProductId { get; set; }
        public string Descripcion { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }
        public DateTime LastBuy { get; set; }

        [DataType(DataType.Currency)]
        public float Stock { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }


        //Relación de muchos a muchos
        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}