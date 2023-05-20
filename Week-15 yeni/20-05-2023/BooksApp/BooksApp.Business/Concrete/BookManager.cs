using BooksApp.Business.Abstract;
using BooksApp.Data.Abstract;
using BooksApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task CreateAsync(Book book)
        {
            await _bookRepository.CreateAsync(book);
        }

        public void Delete(Book book)
        {
            _bookRepository.Delete(book);
        }

        public async Task<List<Book>> GetAllAsync()
        {
            var result = await _bookRepository.GetAllAsync();
            return result;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            var result = await _bookRepository.GetByIdAsync(id);
            return result;
        }

        public void Update(Book book)
        {
            _bookRepository.Update(book);
        }

        public async Task<List<Book>> GetHomePageBooksAsync()
        {
            var result = await _bookRepository.GetHomePageBooksAsync();
            return result;
        }

        public async Task<List<Book>> GetAllActiveBooksAsync(string categoryUrl = null, string authorUrl = null, string publisherUrl = null)
        {
            var result = await _bookRepository.GetAllActiveBooksAsync(categoryUrl, authorUrl, publisherUrl);
            return result;
        }

        public async Task<Book> GetBoookByUrlAsync(string bookUrl)
        {
            var result = await _bookRepository.GetBoookByUrlAsync(bookUrl);
            return result;
        }

    }
}
