using Microsoft.AspNetCore.Mvc;
using Proje.Models;

namespace Proje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Repository repository = new Repository();
            List<Product> products = repository.InitProducts();
            List<Category> categories = repository.InitCategories();
            ViewBag.Kategoriler = categories;
            return View(products);
        }
    }
}
