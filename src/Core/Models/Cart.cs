using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTagHelpers.Core.Models
{
    public class Cart
    {
        public IList<ProductItem> Items { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal ShippingAmount { get; set; }
    }
}
