using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTagHelpers.Core.Models;

namespace BlogTagHelpers.Interfaces
{
    public interface IProductManager
    {
        IList<ProductItem> GetAll();
    }

    public interface ICartManager
    {
        Cart GetCart();
    }
}
