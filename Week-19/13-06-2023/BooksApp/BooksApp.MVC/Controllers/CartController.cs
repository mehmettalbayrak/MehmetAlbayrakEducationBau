using AspNetCoreHero.ToastNotification.Abstractions;
using BooksApp.Business.Abstract;
using BooksApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.MVC.Controllers
{
    public class CartController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICartService _cartService;
        private readonly INotyfService _notify;

        public CartController(UserManager<User> userManager, ICartService cartService, INotyfService notify)
        {
            _userManager = userManager;
            _cartService = cartService;
            _notify = notify;
        }
        public async Task<IActionResult> 
    }
}
