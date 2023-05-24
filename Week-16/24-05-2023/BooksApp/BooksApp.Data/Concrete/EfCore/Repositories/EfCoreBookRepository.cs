using BooksApp.Data.Abstract;
using BooksApp.Data.Concrete.EfCore.Contexts;
using BooksApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreBookRepository : EfCoreGenericRepository<Book>, IBookRepository
    {
        BooksAppContext _context = new BooksAppContext();
        public async Task<List<Book>> GetAllActiveBooksAsync(string categoryUrl = null, string authorUrl = null, string publisherUrl = null)
        {
            
            var result = _context
                .Books
                .Where(b => b.IsActive && !b.IsDeleted)
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .AsQueryable();
            if (categoryUrl!=null)
            {
                result = result
                    .Include(b => b.BookCategories)
                    .ThenInclude(bc => bc.Category)
                    .Where(b => b.BookCategories.Any(bc => bc.Category.Url == categoryUrl))
                    .AsQueryable();
            }
            if (authorUrl != null)
            {
                result = result
                    .Where(b => b.Author.Url == authorUrl)
                    .AsQueryable();
            }
            if (publisherUrl != null)
            {
                result = result
                    .Where(b => b.Publisher.Url == publisherUrl)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }

        public async Task<Book> GetBoookByUrlAsync(string bookUrl)
        {
            var result = await _context
                .Books
                .Where(b => b.IsActive && !b.IsDeleted && b.Url == bookUrl)
                .Include(b => b.BookCategories)
                .ThenInclude(bc => bc.Category)
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Book>> GetHomePageBooksAsync()
        {
            var result = await _context
                .Books
                .Where(b => b.IsActive && !b.IsDeleted && b.IsHome)
                .Include(b => b.BookCategories)
                .ThenInclude(bc => bc.Category)
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .ToListAsync();
            return result;
        }
    }
}
