using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F_Market.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        public string Name { get; set; }
        public string ContactFirstName { get; set; }

        public string ContactLastName { get; set; }

        public string Phone { get; set; }

        public string Addreess { get; set; }

        public string Email { get; set; }

        //Relación de uno a muchos
        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}