using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Entity.Concrete;
using MiniShopApp.mvc.Models;
using System.Diagnostics;

namespace MiniShopApp.mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryManager;
        private readonly IProductService _productManager;
        public HomeController(ICategoryService categoryManager, IProductService productManager)
        {
            _categoryManager = categoryManager;
            _productManager = productManager;
        }
        public async Task<IActionResult> Index()
        {
            
            //Aktif silinmemiş ve ana sayfa ürünlerini getireceğiz.
            //Şimdi bu işleri yapmaya yarayan metotları hazırlayacağız.
            var productList = await _productManager.GetHomePageProductsAsync();
            ProductsCategoriesViewModel viewModel = new ProductsCategoriesViewModel
            {
                Products = productList,
                
            };

            return View(productList);
        }

    }
}


