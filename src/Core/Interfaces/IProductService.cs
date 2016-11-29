using System.Collections.Generic;
using BlogTagHelpers.Core.Models;

namespace BlogTagHelpers.Core.Interfaces
{
    public interface IProductService
    {
        IList<ProductItem> GetAll();
    }
}
