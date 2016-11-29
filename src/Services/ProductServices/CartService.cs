using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTagHelpers.Core.Interfaces;
using BlogTagHelpers.Core.Models;

namespace BlogTagHelpers.Services.ProductServices
{
    public class CartService : ICartService
    {
        private const decimal TaxPercentag = 8.25m;
        public Cart GetCart(IList<ProductItem> productItems)
        {
            var random = new Random();
            var selectedItems = new List<ProductItem>();

            for (var i = 0; i < 3; i++)
            {
                selectedItems.Add(productItems[random.Next(0, productItems.Count)]);
            }

            return new Cart
            {
                Items = selectedItems,
                Subtotal = selectedItems.Aggregate(0m, (current, selectedItem) => current + selectedItem.Price),
                Tax = selectedItems.Aggregate(0m, (current, selectedItem) => current + selectedItem.Price) * (TaxPercentag / 100),
                ShippingAmount = 20m
            };
        }
    }
}
