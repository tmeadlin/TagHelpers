using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTagHelpers.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BlogTagHelpers.Services.ProductServices.IoC
{
    public static class Bindings
    {
        public static void Bind(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IProductService, ProductService>();
            serviceCollection.AddSingleton<ICartService, CartService>();
        }
    }
}
