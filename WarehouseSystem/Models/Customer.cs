using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        public int ZipCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
