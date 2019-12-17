using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }

        [Required]
        [Display(Name = "PO Number")]
        public string PoNumber { get; set; }

        [Required]
        [Display(Name = "Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public Product Product { get; set; }


        [Required]
        public int Count { get; set; }

        public double Cost { get; set; }

        [Required]
        public Supplier Supplier { get; set; }
        public Invoice Invoice { get; set; }
    }
}
