using AspNetCoreHero.ToastNotification.Abstractions;
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
        private readonly INotyfService notfyService;

        public CategoryController(ICategoryService categoryManager, INotyfService notfyService)
        {
            _categoryManager = categoryManager;
            this.notfyService = notfyService;
        }

        #region Listeleme
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //Metoda gönderdiğimiz ilk parametre silinmemiş kayıtları göstermek için.
            //İkinci parametre yollamadık, çünkü aktif ya da pasif tüm kayıtları göstermek istedik.
            //Eğer aktif kayıtları göstermek isteseydik true, pasif kayıtları göstermek isteseydik false göndermemiz gerekirdi.
            List<Category> categoryList = await _categoryManager.GetAllCategoriesAsync(false);
            List<CategoryViewModel> categoryViewModelList = categoryList
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    CreatedDate = c.CreatedDate,
                    ModifiedDate = c.ModifiedDate,
                    Description = c.Description,
                    IsActive = c.IsActive,
                    Url = c.Url
                }).ToList();
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
            if (ModelState.IsValid)
            {
                Category category = new Category
                {
                    Name = categoryAddViewModel.Name,
                    Description = categoryAddViewModel.Description,
                    IsActive = categoryAddViewModel.IsActive,
                    Url = Jobs.GetUrl(categoryAddViewModel.Name)
                };
                await _categoryManager.CreateAsync(category);
                notfyService.Success("Kayıt işlemi başarıyla tamamlanmıştır.");
                return RedirectToAction("Index");
            }
            return View(categoryAddViewModel);
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
                notfyService.Success("Güncelleme başarıyla tamamlanmıştır.");
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            category.IsActive = !category.IsActive;
            category.ModifiedDate = DateTime.Now;
            _categoryManager.Update(category);
            return RedirectToAction("Index");
        }
        #endregion
        #region Kategori Kalıcı Silme
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null) return NotFound();
            CategoryDeleteViewModel categoryDeleteViewModel = new CategoryDeleteViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Url = category.Url,
                IsActive = category.IsActive,
                IsDeleted = category.IsDeleted,
                CreatedDate=category.CreatedDate,
                ModifiedDate=category.ModifiedDate
            };
            return View(categoryDeleteViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null) return NotFound();
            _categoryManager.Delete(category);
            notfyService.Success("Kayıt kalıcı şekilde silinmiştir.");
            return RedirectToAction("Index");
        }
        #endregion
        #region Kategori Soft Silme
        public async Task<IActionResult> SoftDelete(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            category.IsDeleted = true;
            category.ModifiedDate = DateTime.Now;
            _categoryManager.Update(category);
            notfyService.Success("Kayıt geçici olarak silinmiştir. Geri almak için ilgili bölüme geçiniz.");
            return RedirectToAction("Index");
        }
        #endregion
    }
}
