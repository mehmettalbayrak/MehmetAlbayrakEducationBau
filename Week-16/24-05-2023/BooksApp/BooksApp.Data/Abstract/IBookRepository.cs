using BooksApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Abstract
{
    public interface IBookRepository:IGenericRepository<Book>
    {
        Task<List<Book>> GetHomePageBooksAsync();
        Task<List<Book>> GetAllActiveBooksAsync(string categoryUrl = null, string authorUrl = null, string publisherUrl = null);
        Task<Book> GetBoookByUrlAsync(string bookUrl);

        Task<List<Book>> GetAllBooksWithAuthorAndPublisher(bool isDeleted);

    }
}
