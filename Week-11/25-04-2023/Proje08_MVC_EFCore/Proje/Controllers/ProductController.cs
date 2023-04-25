using Microsoft.AspNetCore.Mvc;
using Proje.Models;

namespace Proje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}