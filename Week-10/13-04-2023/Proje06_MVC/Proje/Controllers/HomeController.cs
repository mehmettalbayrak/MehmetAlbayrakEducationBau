using Microsoft.AspNetCore.Mvc;
using Proje.Models;
using Proje.ViewModels;
using System.Diagnostics;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Repository repository = new Repository();
            List<Product> products = repository.InitProducts();
            List<Category> categories = repository.InitCategories();
            ProductsCategories productsCategories = new ProductsCategories
            {
                Products = products,
                Categories = categories
            };
            return View(productsCategories); //Bir View'in tek bir modeli olabilir.
        }


    }
}