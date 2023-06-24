using AspNetCoreHero.ToastNotification.Abstractions;
using BooksApp.Business.Abstract;
using BooksApp.Entity.Concrete;
using BooksApp.Entity.Concrete.ComplexTypes;
using BooksApp.MVC.Areas.Admin.Models;
using BooksApp.MVC.Extensions;
using BooksApp.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooksApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly IOrderService _orderManager;
        private readonly UserManager<User> _userManager;
        private readonly ICartService _cartManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly INotyfService _notyf;

        public HomeController(IOrderService orderManager, UserManager<User> userManager, INotyfService notyf, ICartService cartManager, RoleManager<Role> roleManager)
        {
            _orderManager = orderManager;
            _userManager = userManager;
            _notyf = notyf;
            _cartManager = cartManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var totalSalesAmount = await _orderManager.GetTotalAsync(0);
            var totalSalesCount = await _orderManager.GetTotalAsync(1);
            var totalBookSalesCount = await _orderManager.GetTotalAsync(2);
            AdminDashboardViewModel model = new AdminDashboardViewModel
            {
                TotalSalesAmount = totalSalesAmount == "" ? 0 : Convert.ToDecimal(totalSalesAmount),
                TotalSalesCount = totalSalesCount == "" ? 0 : Convert.ToInt32(totalSalesCount),
                TotalBookSalesCount = totalBookSalesCount == "" ? 0 : Convert.ToInt32(totalBookSalesCount)
            };
            List<Order> receivedOrderList = await _orderManager.GetAllOrdersAsync(null, true, OrderStatus.Received);
            List<OrderViewModel> receivedOrders = receivedOrderList.Select(o => new OrderViewModel
            {
                Id = o.Id,
                FirstName = o.FirstName,
                LastName = o.LastName,
                City = o.City,
                Address = o.Address,
                PhoneNumber = o.PhoneNumber,
                Email = o.Email,
                OrderDate = o.OrderDate,
                OrderItems = o.OrderItems,
                OrderStatus = o.OrderStatus.GetDisplayName()
            }).ToList();
            model.ReceivedOrders = receivedOrders;

            List<Order> preparingOrderList = await _orderManager.GetAllOrdersAsync(null, true, OrderStatus.Preparing);
            List<OrderViewModel> preparingOrders = preparingOrderList.Select(o => new OrderViewModel
            {
                Id = o.Id,
                FirstName = o.FirstName,
                LastName = o.LastName,
                City = o.City,
                Address = o.Address,
                PhoneNumber = o.PhoneNumber,
                Email = o.Email,
                OrderDate = o.OrderDate,
                OrderItems = o.OrderItems,
                OrderStatus = o.OrderStatus.GetDisplayName()
            }).ToList();
            model.PreparingOrders = preparingOrders;


            return View(model);
        }
        #region User İşlemleri
        public async Task<IActionResult> UserList()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }

        public async Task<IActionResult> UserDelete(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            //Silinecek usera atanan rolü kaldırıyoruz.
            await _userManager.RemoveFromRoleAsync(user, "User");
            //Silinecek userın sepetini siliyoruz.
            await _cartManager.DeleteAsync(user.Id);
            //Şimdi de userı silebiliriz.
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                _notyf.Success($"{user.UserName} adlı kullanıcı başarıyla silinmiştir.");
            }
            else
            {
                _notyf.Error("Silme işlemi sırasında bir sorun oluştu.");
            }
            return RedirectToAction("UserList");
        }
        public async Task<IActionResult> ConfirmEmail(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            user.EmailConfirmed = !user.EmailConfirmed;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("UserList");
        }
        [HttpGet]
        public async Task<IActionResult> UserEdit(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            UserUpdateViewModel model = new UserUpdateViewModel
            {
                User = user,
                SelectedRoles = await _userManager.GetRolesAsync(user),
                Roles = await _roleManager.Roles.ToListAsync()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.User.Id);
                user.UserName = model.User.UserName;
                user.FirstName = model.User.FirstName;
                user.LastName = model.User.LastName;
                user.Address = model.User.Address;
                user.EmailConfirmed = model.User.EmailConfirmed;

                //Rol güncellemesi
                var userRoles = await _userManager.GetRolesAsync(user);

                //Rol ata(daha önceden var olan rollere karışma yani onlar hariç)
                await _userManager.AddToRolesAsync(user, model.SelectedRoles.Except(userRoles).ToList<string>()); //Except metodu, kullanıcının hali hazırdaki rolü harici seçilen rol(leri) eklememizi sağlayacaktır.
                //Rol çıkar(hariç olanlar.)
                await _userManager.RemoveFromRolesAsync(user, userRoles.Except(model.SelectedRoles).ToList<string>());
                _notyf.Success("Kullanıcı Bilgileri Başarıyla Güncellenmiştir.");
                return RedirectToAction("UserList");
            }
            return View(model);
        }
        #endregion

        #region Role İşlemleri
        public async Task<IActionResult> RoleList()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }
        [HttpGet]
        public async Task<IActionResult> RoleEdit(string id)
        {
            Role role = await _roleManager.FindByIdAsync(id);
            var users = await _userManager.Users.ToListAsync();
            var members = new List<User>();
            var nonMembers = new List<User>();
            List<User> list = new List<User>();

            foreach (var user in users)
            {
                list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);

            }
            RoleUpdateViewModel model = new RoleUpdateViewModel
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleUpdateViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Role.Id);
            foreach (var userId in model.IdsToAdd)
            {

            }

            foreach (var userId in model.IdsFromRemove)
            {

            }
        }
        #endregion
    }
}
