using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogTagHelpers.Core.Interfaces;
using BlogTagHelpers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductManager _productManager;
        private readonly ICartManager _cartManager;

        public HomeController(IProductManager productManager, ICartManager cartManager)
        {
            _productManager = productManager;
            _cartManager = cartManager;
        }

        public IActionResult Index()
        {
            var productItems = _productManager.GetAll();
            return View("ProductItems", productItems);
        }

        public IActionResult Checkout()
        {
            var cart = _cartManager.GetCart();
            return View("Checkout", cart);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
