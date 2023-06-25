using AspNetCoreHero.ToastNotification.Abstractions;
using BooksApp.Business.Abstract;
using BooksApp.Entity.Concrete;
using BooksApp.MVC.Models;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.MVC.Controllers
{
    public class CartController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICartService _cartManager;
        private readonly ICartItemService _cartItemManager;
        private readonly INotyfService _notyf;

        public CartController(UserManager<User> userManager, ICartService cartManager, INotyfService notyf, ICartItemService cartItemManager)
        {
            _userManager = userManager;
            _cartManager = cartManager;
            _notyf = notyf;
            _cartItemManager = cartItemManager;
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
            await _cartManager.AddToCart(userId,id, quantity);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> ChangeQuantity(int cartItemId, int quantity)
        {
            if (ModelState.IsValid)
            {
                await _cartItemManager.ChangeQuantityAsync(cartItemId, quantity);
            }
            else
            {
                _notyf.Warning("Lütfen adedi boş bırakmayınız");
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteItemFromCart(int id)
        {
            var cartItem = await _cartItemManager.GetByIdAsync(id);
            _cartItemManager.Delete(cartItem);
            _notyf.Success("Kitap sepetinizden silindi");
            return RedirectToAction("Index");
        }
        public IActionResult ClearCart(int id)
        {
            _cartItemManager.ClearCart(id);
            _notyf.Success("Sepetiniz boşaltılmıştır.");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            string userId = _userManager.GetUserId(User);
            User user = await _userManager.FindByIdAsync(userId);
            Cart cart = await _cartManager.GetCartByUserId(userId);
            OrderViewModel model = new OrderViewModel
            {
                FirstName = user.FirstName,
                LastName=user.LastName,
                Address=user.Address,
                City=user.City,
                PhoneNumber=user.PhoneNumber,
                Email=user.Email,
                Cart = new CartViewModel
                {
                    CartId=cart.Id,
                    CartItems = cart.CartItems.Select(ci=>new CartItemViewModel
                    {
                        CartItemId=ci.Id,
                        BookId=ci.BookId,
                        BookName=ci.Book.Name,
                        Price=ci.Book.Price,
                        Quantity=ci.Quantity,
                        BookImageUrl=ci.Book.ImageUrl
                    }).ToList()
                },
                CardName="Alex de Souza",
                CardNumber= "5890040000000016",
                ExpirationYear="2028",
                ExpirationMonth="10",
                Cvc="123"
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Checkout(OrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Ödeme işlemini yapacağız
                //PaymentProcess(model);
            }
            return null;
        }
        [NonAction]
        private Payment PaymentProcess(OrderViewModel model)
        {
            #region Options
            Options options = new Options();
            options.ApiKey = "sandbox-313Mg6w05g35vEZZXgG5dL5YW6LiUGJl";
            options.SecretKey = "sandbox-tkue5CZOz5usUARA3DmXPQAVnbJkcXx5";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";
            #endregion
            #region Request
            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Price = Convert.ToInt32(model.Cart.TotalPrice()).ToString();
            request.PaidPrice = Convert.ToInt32(model.Cart.TotalPrice()).ToString();
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = model.Cart.CartId.ToString();
            request.PaymentChannel = PaymentChannel.MOBILE_WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
                #region PaymentCard
                PaymentCard paymentCard = new PaymentCard();
                paymentCard.CardHolderName = model.CardName;
                paymentCard.CardNumber = model.CardNumber;
                paymentCard.ExpireMonth = model.ExpirationMonth;
                paymentCard.ExpireYear = model.ExpirationYear;
                paymentCard.Cvc = model.Cvc;
                paymentCard.RegisterCard = 0;
                request.PaymentCard = paymentCard;
            #endregion
                #region Buyer
                Buyer buyer = new Buyer();
                buyer.Id = "12345";
                buyer.Name = model.FirstName;
                buyer.Surname = model.LastName;
                buyer.GsmNumber = model.PhoneNumber;
                buyer.Email = model.Email;
                buyer.IdentityNumber = "74300864791";
                buyer.LastLoginDate = "2015-10-05 12:43:35";
                buyer.RegistrationDate = "2013-04-21 15:12:09";
                buyer.RegistrationAddress = model.Address;
                buyer.Ip = "85.34.78.112";
                buyer.City = model.City;
                buyer.Country = "Turkey";
                buyer.ZipCode = "34732";
                request.Buyer = buyer;
                #endregion
            #endregion
            return null;
        }
    }
}
