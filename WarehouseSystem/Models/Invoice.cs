using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    public class Invoice
    {
        [Key]
        public int invoiceId { get; set; }

        [Display(Name = "Number")]
        public int InvoiceNumber { get; set; }

        [Display(Name = "Amount")]
        public double InvoiceAmount { get; set; }

        [Display(Name = "Payment Status")]
        public bool IsPaid { get; set; }

    }
}
