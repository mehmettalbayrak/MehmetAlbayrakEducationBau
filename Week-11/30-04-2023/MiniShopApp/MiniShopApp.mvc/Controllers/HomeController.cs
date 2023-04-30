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
        public IActionResult Index()
        {
            //List<Category> categories = _categoryManager.GetAll();
            //return View(categories);
            List<Product> products = _productManager.GetAll();
            return View(products);
        }

    }
}


