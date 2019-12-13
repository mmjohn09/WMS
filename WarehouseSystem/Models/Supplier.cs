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
        public string Name { get; set; }

        [Display(Name = "Payment Terms")]
        public string PaymentTerms { get; set; }

        [Required]
        public string Address { get; set; }

        public List<Product> Products { get; set; }

        public List<Purchase> Purchases { get; set; }
        
        
        [Display(Name = "Account Rep")]
        public string AccountRep { get; set; }

        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
