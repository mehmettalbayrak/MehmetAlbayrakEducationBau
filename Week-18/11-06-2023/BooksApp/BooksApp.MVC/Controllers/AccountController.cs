using AspNetCoreHero.ToastNotification.Abstractions;
using BooksApp.Entity.Concrete;
using BooksApp.MVC.EmailServices.Abstract;
using BooksApp.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly INotyfService _notify;
        private readonly IEmailSender _smtpEmailSender;

        public AccountController(UserManager<User> userManager, INotyfService notify, SignInManager<User> signInManager, IEmailSender smtpEmailSender)
        {
            _userManager = userManager;
            _notify = notify;
            _signInManager = signInManager;
            _smtpEmailSender = smtpEmailSender;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            LoginViewModel model = new LoginViewModel
            {
                IsPersistent = true,
                ReturnUrl = returnUrl
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByNameAsync(model.UserName);
                if (user == null)
                {
                    _notify.Error("Giriş bilgilerinde hata var, yeniden deneyiniz!");
                    return View(model);
                }
                #region Onaylı Mı Kontrolü
                /*if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    _notify.Warning("Hesabınız onaylı değil. Lüfen Email adresinizi onaylayınız.");
                    return View(model);
                }*/
                #endregion
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.IsPersistent, true);
                if (result.Succeeded)
                {
                    _notify.Success("Başarıyla giriş yaptınız!");
                    return Redirect(model.ReturnUrl ?? "~/"); //null kontrolü. direkt null değilse böyle yap demek.
                }
                else if (result.IsLockedOut)
                {
                    var sure = _signInManager.Options.Lockout.DefaultLockoutTimeSpan.TotalMinutes;
                    _notify.Warning($"Hesabınız kilitlenmiştir. {sure} dk sonra yeniden deneyiniz.");
                    return View(model);
                }
                else
                {
                    var kalanHak = _signInManager.Options.Lockout.MaxFailedAccessAttempts - await _userManager.GetAccessFailedCountAsync(user);
                    _notify.Warning($"{kalanHak} kez deneme hakkınız kaldı. Eğer sınıra ulaşırsanız, hesabınız kilitlenecektir.");
                    return View(model);
                }
            }
            _notify.Error("Giriş bilgilerinde hata var, yeniden deneyiniz!");
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
                    #region Onay Maili Gönderme
                    ////token oluşturuyoruz.
                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    ////url oluşturuyoruz.
                    //var url = Url.Action("ConfirmEmail", "Account", new
                    //{
                    //    userId = user.Id,
                    //    token = code
                    //});
                    //var email = model.Email;
                    //var subject = "BooksApp Onay Maili";
                    //var body = $"<h1> BooksApp Onay İşlemi</h1>" +
                    //            $"<p>" +
                    //            $"Lütfen üyeliğinizi onaylamak için <a href='http://localhost:5200{url}'> tıklayınız.</a>." +
                    //            $"</p>";
                    //await _smtpEmailSender.SendEmailAsync(email, subject, body);
                    #endregion
                    await _userManager.AddToRoleAsync(user, "User");
                    _notify.Success("Kayıt işlemi başarıyla tamamlandı. Email adresinize gönderilen onaylama linkine tıklayınız.");
                    return RedirectToAction("Login");
                }
                _notify.Error("Bir hata oluştu, yeniden deneyiniz.");
            }
            return View(model);
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    _notify.Success("Hesabınız başarıyla onaylanmıştır.");
                    return RedirectToAction("Login");
                }
            }
            _notify.Error("Bir sorun oluştu. Lütfen teknik ekiple iletişime geçiniz.");
            return Redirect("~/");
        }
        public async Task<IActionResult> ForgotPassword(string userId, string token)
        {
            var subject = "BooksApp şifre sıfırlama";
            var body = $"<h1>BooksApp Şifre Sıfırlama İşlemi</h1>" +
                $"Lütfen şifrenizi değiştirmek için "

            return RedirectToAction("Login");
        }
        [HttpGet]
        public async Task<IActionResult> ResetPassword(string userId, string token)
        {

        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.UserId);
                if (user == null)
                {
                    _notify.Warning("Kullanıcı bulunamadı.");
                    return View();
                }
                var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
                if (result.Succeeded)
                {
                    _notify.Success("Şifreniz başarıyla değiştirilmiştir.");
                    return RedirectToAction("Login");
                }
            }
            _notify.Warning("Bir sorun oluştu.");
            return View();
        }
    }
}
