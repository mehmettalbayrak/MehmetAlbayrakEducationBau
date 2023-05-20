using BooksApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Business.Abstract
{
    public interface IBookService
    {
        #region Generic
        Task<Book> GetByIdAsync(int id);
        Task<List<Book>> GetAllAsync();
        Task CreateAsync(Book book);
        void Update(Book book);
        void Delete(Book book);
        #endregion

        #region Book
        Task<List<Book>> GetHomePageBooksAsync();
        Task<List<Book>> GetAllActiveBooksAsync(string categoryUrl=null, string authorUrl=null, string publisherUrl=null);
        Task<Book> GetBoookByUrlAsync(string bookUrl);
        #endregion
    }
}
