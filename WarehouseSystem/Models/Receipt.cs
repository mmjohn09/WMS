using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    public class Receipt
    {
        [Key]
        public int ReceiptId { get; set; }

        public Purchase Purchase { get; set; } 
        public DateTime ReceiptDate { get; set; }
        public ApplicationUser User { get; set; }

        [Display(Name = "Received By")]
        public string UserId { get; set; }

    }
}
