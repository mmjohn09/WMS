using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }

        [Required]
        [Display(Name = "Purchase Order Number")]
        public int PoNumber { get; set; }

        [Required]
        [Display(Name = "Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public Product Product { get; set; }

        public int ProductId { get; set; }

        [Required]
        public int Count { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Total { get; set; }

        public Invoice Invoice { get; set; }
        public Supplier Supplier { get; set;}
        public int SupplierId { get; set; }

        [Display(Name = "Received")]
        public bool isReceived { get; set; }
    }
}
