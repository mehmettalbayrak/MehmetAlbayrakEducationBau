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

        public async Task CreateBookAsync(Book book, List<int> SelectedCategoryIds)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            book.BookCategories = SelectedCategoryIds.Select(sc => new BookCategory
            {
                BookId = book.Id,
                CategoryId = sc
            }).ToList();
            _context.Books.Update(book);
            await _context.SaveChangesAsync();


            //List<BookCategory> bookCategories = new List<BookCategory>();
            //foreach (var categoryId in SelectedCategoryIds)
            //{
            //    bookCategories.Add(new BookCategory
            //    {
            //        BookId = book.Id,
            //        CategoryId = categoryId
            //    });
            //}
            //book.BookCategories = bookCategories;
            //_context.Books.Update(book);
            //await _context.SaveChangesAsync();
        }

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

        public async Task<List<Book>> GetAllBooksWithAuthorAndPublisher(bool isDeleted)
        {
            var result = await _context
                .Books
                .Where(b => b.IsDeleted == isDeleted)
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .ToListAsync();
            return result;
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            var result = await _context
                .Books
                .Where(b => b.IsActive && !b.IsDeleted && b.Id==id)
                .Include(b => b.BookCategories)
                .ThenInclude(bc => bc.Category)
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync();
            return result;
        }

        public async Task<Book> GetBookByUrlAsync(string bookUrl)
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

        public async Task<List<Book>> GetBooksWithFullDataAsync(bool? isHome=null, bool? isActive = null)
        {
            var result = _context
                .Books
                .Where(b => !b.IsDeleted)
                .AsQueryable();

            if (isHome!=null)
            {
                result = result
                    .Where(b => b.IsHome == isHome)
                    .AsQueryable();
            }

            if (isActive!=null)
            {
                result = result
                    .Where(b => b.IsActive == isActive)
                    .AsQueryable();
            }
            result = result
                .Include(b => b.BookCategories)
                .ThenInclude(bc => bc.Category)
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .AsQueryable();

            return await result.ToListAsync();
        }
    }
}
