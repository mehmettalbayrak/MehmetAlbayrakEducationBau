using BooksApp.Business.Abstract;
using BooksApp.Entity.Concrete;
using BooksApp.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly IBookService _bookManager;

        public BookController(IBookService bookManager)
        {
            _bookManager = bookManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Book> books = await _bookManager.GetAllBooksAuthorAndPublisher(false);
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
    }
}
