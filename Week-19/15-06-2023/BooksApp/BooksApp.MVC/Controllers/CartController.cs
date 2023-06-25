using AspNetCoreHero.ToastNotification.Abstractions;
using BooksApp.Business.Abstract;
using BooksApp.Entity.Concrete;
using BooksApp.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.MVC.Controllers
{
    public class CartController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICartService _cartManager;
        private readonly INotyfService _notyf;

        public CartController(UserManager<User> userManager, ICartService cartManager, INotyfService notyf)
        {
            _userManager = userManager;
            _cartManager = cartManager;
            _notyf = notyf;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var cart = await _cartManager.GetCartByUserId(userId);
            CartViewModel model = new CartViewModel
            {
                CartId = cart.Id,
                CartItems = cart.CartItems
                    .Select(ci => new CartItemViewModel
                    {
                        CartItemId = ci.Id,
                        BookId = ci.Book.Id,
                        BookName = ci.Book.Name,
                        BookUrl = ci.Book.Url,
                        BookImageUrl = ci.Book.ImageUrl,
                        Price = ci.Book.Price,
                        Quantity = ci.Quantity
                    }).ToList()
            };
            return View(model);
        }
        public async Task<IActionResult> AddToCart(int id, int quantity)
        {
            var userId = _userManager.GetUserId(User);
            await _cartManager.AddToCart(userId, id, quantity);
            return RedirectToAction("Index");
        }
    }
}
