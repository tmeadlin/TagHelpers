using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTagHelpers.Core.Models;

namespace BlogTagHelpers.Core.Interfaces
{
    public interface ICartService
    {
        Cart GetCart(IList<ProductItem> productItems);
    }
}
