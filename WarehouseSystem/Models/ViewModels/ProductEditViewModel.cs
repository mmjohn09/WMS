using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models.ViewModels
{
    public class ProductEditViewModel
    {
        public Product Product { get; set; }

        public List<Supplier> Suppliers { get; set; }
        public List<SelectListItem> SupplierOptions
        {
            get
            {
                return Suppliers?.Select(s => new SelectListItem(s.Name, s.SupplierId.ToString())).ToList();
            }
        }
    }
}
