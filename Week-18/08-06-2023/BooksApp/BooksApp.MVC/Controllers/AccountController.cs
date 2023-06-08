using AspNetCoreHero.ToastNotification.Abstractions;
using BooksApp.Entity.Concrete;
using BooksApp.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Specialized;

namespace BooksApp.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly INotyfService _notify;

        public AccountController(UserManager<User> userManager, INotyfService notify, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _notify = notify;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByNameAsync(model.UserName);
                if (user == null)
                {
                    _notify.Error("Kullanıcı adı veya şifre hatalı!");
                    return View(model);
                }
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    _notify.Success("Başarıyla giriş yaptınız.");
                    return RedirectToAction("Index", "Home");
                }
                _notify.Error("Kullanıcı adı veya şifre hatalı!");
            }
            return View(model);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //Buraya email onayı ile ilgili kodları yazacağız.
                    await _userManager.AddToRoleAsync(user, "User");
                    _notify.Success("Kayıt işlemi başarıyla tamamlandı. Giriş yapabilirsiniz.");
                    return RedirectToAction("Login"); 
                }
                _notify.Error("Bir hata oluştu, yeniden deneyiniz.");
            }
            return View(model);
        }
    }
}
