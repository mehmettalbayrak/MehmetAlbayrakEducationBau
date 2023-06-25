using AspNetCoreHero.ToastNotification.Abstractions;
using BooksApp.Business.Abstract;
using BooksApp.Core;
using BooksApp.Entity.Concrete;
using BooksApp.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BooksApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly IBookService _bookManager;
        private readonly IAuthorService _authorManager;
        private readonly IPublisherService _publisherManager;
        private readonly ICategoryService _categoryManager;
        private readonly INotyfService _notyf;

        public BookController(IBookService bookManager, IAuthorService authorManager, IPublisherService publisherManager, ICategoryService categoryManager, INotyfService notyf)
        {
            _bookManager = bookManager;
            _authorManager = authorManager;
            _publisherManager = publisherManager;
            _categoryManager = categoryManager;
            _notyf = notyf;
        }

        #region Listeleme
        public async Task<IActionResult> Index()
        {
            List<Book> books = await _bookManager.GetAllBooksWithAuthorAndPublisher(false);
            List<BookViewModel> bookViewModelList = books
                .Select(b => new BookViewModel
                {
                    Id = b.Id,
                    Name = b.Name,
                    Price = b.Price,
                    ImageUrl = b.ImageUrl,
                    IsActive = b.IsActive,
                    AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                    PublisherName = b.Publisher.Name
                }).ToList();
            return View(bookViewModelList);
        }
        #endregion
        #region Yardımcı Metotlar(Action olmayanlar)
        [NonAction]
        private async Task<List<SelectListItem>> GetAuthorSelectList()
        {
            List<Author> authorList = await _authorManager.GetAllAuthorsAsync(false, true);
            List<SelectListItem> authorViewModelList = authorList.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.FirstName + " " + a.LastName
            }).ToList();
            return authorViewModelList;
        }
        private async Task<List<SelectListItem>> GetPublisherSelectList()
        {
            List<Publisher> publisherList = await _publisherManager.GetAllPublishersAsync(false, true);
            List<SelectListItem> publisherViewModelList = publisherList.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Name
            }).ToList();
            return publisherViewModelList;
        }
        private async Task<List<CategoryViewModel>> GetCategorySelectList()
        {
            List<Category> categoryList = await _categoryManager.GetAllCategoriesAsync(false, true);
            List<CategoryViewModel> categoryViewModelList = categoryList.Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();
            return categoryViewModelList;
        }
        private async Task<List<SelectListItem>> GetYearSelectList(int startYear, int endYear)
        {
            List<int> years = Jobs.GetYears(startYear, endYear);
            List<SelectListItem> yearList = years.Select(y => new SelectListItem
            {
                Value = y.ToString(),
                Text = y.ToString()
            }).ToList();
            return yearList;
        }
        #endregion
        #region Yeni Kitap
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var authorViewModelList = await GetAuthorSelectList();

            var publisherViewModelList = await GetPublisherSelectList();

            var categoryViewModelList = await GetCategorySelectList();
            
            var yearViewModelList = await GetYearSelectList(1900, DateTime.Now.Year);
            
            BookAddViewModel bookAddViewModel = new BookAddViewModel
            {
                AuthorList = authorViewModelList,
                PublisherList = publisherViewModelList,
                CategoryList = categoryViewModelList,
                YearList = yearList
            };
            return View(bookAddViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BookAddViewModel bookAddViewModel)
        {
            if (ModelState.IsValid && bookAddViewModel.SelectedCategoryIds.Count > 0)
            {
                var url = Jobs.GetUrl(bookAddViewModel.Name);
                Book book = new Book
                {
                    Name = bookAddViewModel.Name,
                    About = bookAddViewModel.About,
                    EditionNumber = bookAddViewModel.EditionNumber,
                    EditionYear = bookAddViewModel.EditionYear,
                    IsActive = bookAddViewModel.IsActive,
                    IsHome = bookAddViewModel.IsHome,
                    PageCount = bookAddViewModel.PageCount,
                    Stock = bookAddViewModel.Stock,
                    ModifiedDate = DateTime.Now,
                    AuthorId = bookAddViewModel.AuthorId,
                    PublisherId = bookAddViewModel.PublisherId,
                    Price = bookAddViewModel.Price,
                    Url = url,
                    ImageUrl = Jobs.UploadImage(bookAddViewModel.ImageFile, url, "books")
                };
                await _bookManager.CreateBookAsync(book, bookAddViewModel.SelectedCategoryIds);
                _notyf.Success("Kayıt işlemi başarıyla tamamlanmıştır.");
                return RedirectToAction("Index");
            }
            if (bookAddViewModel.SelectedCategoryIds.Count == 0)
            {
                ViewBag.CategoryErrorMessage = "En az bir kategori seçilmelidir.";
            }
            #region Yazar Bilgileri
            List<Author> authorList = await _authorManager.GetAllAuthorsAsync(false, true);
            List<SelectListItem> authorViewModelList = authorList.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.FirstName + " " + a.LastName
            }).ToList();
            #endregion
            #region Yayınevi Bilgileri
            List<Publisher> publisherList = await _publisherManager.GetAllPublishersAsync(false, true);
            List<SelectListItem> publisherViewModelList = publisherList.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Name
            }).ToList();
            #endregion
            #region Kategori Bilgileri
            List<Category> categoryList = await _categoryManager.GetAllCategoriesAsync(false, true);
            List<CategoryViewModel> categoryViewModelList = categoryList.Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();
            #endregion
            #region Basım Yılı Listesi
            List<int> years = Jobs.GetYears(1900, 2023);
            List<SelectListItem> yearList = years.Select(y => new SelectListItem
            {
                Value = y.ToString(),
                Text = y.ToString()
            }).ToList();
            #endregion
            bookAddViewModel.AuthorList = authorViewModelList;
            bookAddViewModel.PublisherList = publisherViewModelList;
            bookAddViewModel.CategoryList = categoryViewModelList;
            bookAddViewModel.YearList = yearList;
            return View(bookAddViewModel);
        }
        #endregion
        #region Kitap Güncelleme
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            Book book = await _bookManager.GetBookByIdAsync(id);
            {
                return View();
            }
        }
        #endregion
    }
}
