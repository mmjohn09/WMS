using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseSystem.Models.ViewModels
{
    public class PurchaseCreateViewModel
    {
        public Purchase Purchase { get; set; }
        public DateTime PurchaseDate { get; set; }

        public List<Supplier> Suppliers { get; set; }

        public List<SelectListItem> SupplierOptions
        {
            get
            {
                var SupplierOptions = Suppliers?.Select(s => new SelectListItem(s.Name, s.SupplierId.ToString())).ToList();
                SupplierOptions?.Insert(0, new SelectListItem()
                {
                    Value = string.Empty,
                    Text = "Select Vendor"
                });

                return SupplierOptions;
            }
        }

        public List<Product> Products { get; set; }
        public List<SelectListItem> ProductOptions
        {
            get
            {
                var ProductOptions = Products?.Select(p => new SelectListItem(p.Name, p.ProductId.ToString())).ToList();
                ProductOptions?.Insert(0, new SelectListItem()
                {
                    Value = string.Empty,
                    Text = "Select Product"
                });

                return ProductOptions;
            }
        }
    }
}
