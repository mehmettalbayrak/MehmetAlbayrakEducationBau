using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Entity.Concrete;
using MiniShopApp.mvc.Models;

namespace MiniShopApp.mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;

        public ProductController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public async Task<IActionResult> Index(string categoryUrl)
        {
            List<Product> products = await _productManager.GetActiveProductsAsync(categoryUrl);
            return View(products);
        }
        public async Task<IActionResult> Details(string url)
        {
            var product = await _productManager.GetProductByUrlAsync(url);
            var viewModel = new ProductViewModel
            {
                id = product.Id,
                Name = product.Name,
                ModifiedDate = product.ModifiedDate,
                Properties = product.Properties,
                Price = product.Price,
                Url = product.Url,
                ImageUrl = product.ImageUrl,
                CategoryList = product.ProductCategories.Select(pc => pc.Category).ToList()
            };
            return View(product);
        }
    }
}