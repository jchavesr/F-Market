using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace F_Market.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string ContactFirstName { get; set; }

        public string ContactLastName { get; set; }

        public string Phone { get; set; }

        public string Addreess { get; set; }

        public string Email { get; set; }

        public string Document { get; set; }
        public int DocumentTypeId { get; set; }

        //[NotMapped]
        public string FullName
        {
            get { return string.Format("{0} {1}", ContactFirstName, ContactLastName); }  }

        public virtual DocumentType DocumentType { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}