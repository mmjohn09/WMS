using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required]
        [Display(Name = "Vendor")]
        public string Name { get; set; }

        [Display(Name = "Payment Terms")]
        public string PaymentTerms { get; set; }

        [Required]
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode {get; set;}
        
        [Display(Name = "Account Rep")]
        public string AccountRep { get; set; }

        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<Product> Products { get; set; }

        public List<Purchase> Purchases { get; set; }
    }
}
