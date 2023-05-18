using BooksApp.Business.Abstract;
using BooksApp.Entity.Concrete;
using BooksApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.MVC.Controllers
{
    public class BooksShopController : Controller
    {
        private readonly IBookService _bookManager;

        public BooksShopController(IBookService bookManager)
        {
            _bookManager = bookManager;
        }

        public async Task<IActionResult> BookList(string categoryurl=null, string authorurl=null)
        {
            List<Book> bookList = await _bookManager.GetAllActiveBooksAsync(categoryurl, authorurl);
            List<BookViewModel> bookViewModelList = bookList.Select(b => new BookViewModel
            {
                Id = b.Id,
                Name = b.Name,
                Price = b.Price,
                Url = b.Url,
                ImageUrl = b.ImageUrl,
                AuthorName = b.Author.FirstName,
                AuthorUrl = b.Author.Url,
                PublisherName = b.Publisher.Name,
                PublisherUrl = b.Publisher.Url
            }).ToList();
            return View(bookViewModelList);
        }
    }
}
