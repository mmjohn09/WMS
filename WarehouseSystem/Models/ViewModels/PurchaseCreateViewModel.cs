using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models.ViewModels
{
    public class PurchaseCreateViewModel
    {
        public Purchase Purchase { get; set; }

        public string SelectedProduct { get; set; }
        public IEnumerable<SelectListItem> Product { get; set; }

        public string SelectedSupplier { get; set; }
        public IEnumerable<SelectListItem> Supplier { get; set; }
    }
}
