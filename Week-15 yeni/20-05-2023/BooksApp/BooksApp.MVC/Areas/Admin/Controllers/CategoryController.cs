using BooksApp.Business.Abstract;
using BooksApp.Core;
using BooksApp.Entity.Concrete;
using BooksApp.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;

        public CategoryController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        #region Listeleme
        public async Task<IActionResult> Index()
        {
            //metoda gönderdiğimiz ilk parametre silinmemiş kayıtları göstermek için. 
            //İkinci parametre yollamadık çünkü aktif ya da pasif tüm kayıtları göstermek istedik.
            //Eğer aktif kayıtları göstermek isteseydik. True tersinde false.
            List<Category> categoryList = await _categoryManager.GetAllNondeletedCategoriesAsync(false); //kategori listesini çektik.
            List<CategoryViewModel> categoryViewModelList = categoryList.Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name,
                CreatedDate = c.CreatedDate,
                Description = c.Description,
                IsActive = c.IsActive,
                ModifiedDate = c.ModifiedDate,
                Url = c.Url
            }
            ).ToList();

            return View(categoryViewModelList);
        }
        #endregion

        #region Yeni Kategori
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddViewModel categoryAddViewModel)
        {
            if (ModelState.IsValid) //Modele girilen her şey uygunsa demek.
            {
                Category category = new Category
                {
                    Name = categoryAddViewModel.Name,
                    Description = categoryAddViewModel.Description,
                    IsActive = categoryAddViewModel.IsActive,
                    Url = Jobs.GetUrl(categoryAddViewModel.Name)
                };
                await _categoryManager.CreateAsync(category);
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion
        #region Kategori Güncelleme
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            CategoryEditViewModel categoryEditViewModel = new CategoryEditViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                IsActive = category.IsActive,
                IsDeleted = category.IsDeleted
            };

            return View(categoryEditViewModel);
        }
        #endregion

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryEditViewModel categoryEditViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = await _categoryManager.GetByIdAsync(categoryEditViewModel.Id);
                category.Name = categoryEditViewModel.Name;
                category.Description = categoryEditViewModel.Description;
                category.IsActive = categoryEditViewModel.IsActive;
                category.IsDeleted = categoryEditViewModel.IsDeleted;
                categoryEditViewModel.Url = Jobs.GetUrl(categoryEditViewModel.Name);
                category.Url = categoryEditViewModel.Url;
                category.ModifiedDate = DateTime.Now;
                _categoryManager.Update(category);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
