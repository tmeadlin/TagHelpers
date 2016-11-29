using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTagHelpers.Core.Interfaces;
using BlogTagHelpers.Core.Models;
using BlogTagHelpers.Interfaces;

namespace BlogTagHelpers.Managers
{
    public class ProductManager : IProductManager
    {
        private readonly IProductService _productService;

        public ProductManager(IProductService productService)
        {
            _productService = productService;
        }

        #region IProductManager Methods

        public IList<ProductItem> GetAll()
        {
            return _productService.GetAll();
        }

        #endregion
    }
}
