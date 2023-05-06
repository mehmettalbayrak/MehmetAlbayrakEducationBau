using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;

namespace MiniShopApp.mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;
        public CategoryController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public async Task<IActionResult> Index()
        {
            var categoryList = await _categoryManager.GetAllAsync();
            return View(categoryList);
        }
    }
}
