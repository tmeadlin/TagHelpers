using System;
using System.Collections.Generic;
using BlogTagHelpers.Core.Interfaces;
using BlogTagHelpers.Core.Models;

namespace BlogTagHelpers.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IList<ProductItem> _items = new List<ProductItem>();
        public ProductService()
        {
            GenerateItems();
        }

        public IList<ProductItem> GetAll()
        {
            return _items;
        }
                
        #region Helper Methods

        //Since this is test solution...we don't need to go to a DB to get this data
        private void GenerateItems()
        {
            var random = new Random();

            for (int i = 0; i < 25; i++)
            {
                _items.Add(new ProductItem
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = "Cupcake ipsum dolor sit. Amet I love liquorice jujubes pudding croissant I love pudding. Apple pie macaroon toffee jujubes pie tart cookie applicake caramels. Halvah macaroon I love lollipop. Wypas I love pudding brownie cheesecake tart jelly-o. Bear claw cookie chocolate bar jujubes toffee",
                    Price = random.Next(1000, 5000),
                    ImageName = "Computer"
                });
            }
        }

        #endregion
    }
}
