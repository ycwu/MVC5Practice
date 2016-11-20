using System;

namespace MVC5Practice.Models.ViewModels
{
    public class ProductBatchUpdateViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<decimal> Stock { get; set; }
    }
}