using Microsoft.AspNetCore.Mvc;

namespace BooksApp.MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
