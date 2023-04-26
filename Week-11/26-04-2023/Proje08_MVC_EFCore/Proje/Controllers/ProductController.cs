using Microsoft.AspNetCore.Mvc;
using Proje.Models;

namespace Proje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            using (var _context = new ProjeAppContext())
            {
                List<Product> products = _context.Products.ToList();
                return View(products);
            }
        }
    }
}