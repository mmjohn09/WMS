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
        public int PurchaseId { get; set; }
        public DateTime ReceiveDate { get; set; }
        public int QtyReceived { get; set; }
        public ApplicationUser User { get; set; }

        [Display(Name = "Received By")]
        public string UserId { get; set; }

    }
}
