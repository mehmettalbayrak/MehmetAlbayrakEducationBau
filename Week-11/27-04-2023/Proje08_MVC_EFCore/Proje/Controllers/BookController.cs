using Microsoft.AspNetCore.Mvc;

namespace Proje.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
