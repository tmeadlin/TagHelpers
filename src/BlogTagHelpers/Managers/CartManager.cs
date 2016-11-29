using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTagHelpers.Core.Interfaces;
using BlogTagHelpers.Core.Models;
using BlogTagHelpers.Interfaces;

namespace BlogTagHelpers.Managers
{
    public class CartManager : ICartManager
    {
        private readonly ICartService _cartService;
        private readonly IProductService _productService;

        public CartManager(ICartService cartService, IProductService productService)
        {
            _cartService = cartService;
            _productService = productService;
        }

        #region ICartManager Methods

        public Cart GetCart()
        {
            return _cartService.GetCart(_productService.GetAll());
        }

        #endregion
    }
}
