using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Entity.Concrete;

namespace MiniShopApp.mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;

        public ProductController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _productManager.GetActiveProductsAsync();
            return View(products);
        }
    }
}