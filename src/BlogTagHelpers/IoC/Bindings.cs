using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTagHelpers.Interfaces;
using BlogTagHelpers.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace BlogTagHelpers.IoC
{
    public static class Bindings
    {
        public static void Bind(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IProductManager, ProductManager>();
            serviceCollection.AddSingleton<ICartManager, CartManager>();
        }
    }
}
