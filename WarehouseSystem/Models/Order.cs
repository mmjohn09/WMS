using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Completed Date")]
        public DateTime CompletedDate { get; set; }
        public int CustomerId { get; set; }

        [Display(Name = "Order Quantity")]
        public int OrderQty { get; set; }

        [Display(Name = "Completed By")]
        public int UserId { get; set; }

        public ApplicationUser User { get; set; }
    }


}
