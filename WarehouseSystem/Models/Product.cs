using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Date Added")]
        public DateTime DateCreated { get; set; }

        [Required]
        [StringLength(255)]
        [RegularExpression(@"([a-zA-Z0-9_\s\-]*)$", ErrorMessage = "Special Characters are not permitted: !@#$%^&*()")]
        public string Name { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "Please shorten the product title to 55 characters")]
        [RegularExpression(@"([a-zA-Z0-9_\s\-]*)*$", ErrorMessage = "Special Characters are not permitted: !@#$%^&*()")]
        public string Description { get; set; }

        [Required]
        [Range(0.00, 10000, ErrorMessage = "Price cannot exceed 10,000.")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Quantity On Hand")]
        public int QtyOnHand { get; set; }

        [Required]
        [Display(Name = "Minimum Quantity")]
        public int MinimumQuantity { get; set; }

        [Required]
        [Display(Name = "Lead Time")]
        public int LeadTime { get; set; }

        [Required]
        public Supplier Supplier { get; set; }

    }
}
