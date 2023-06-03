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
    public class EfCoreAuthorRepository:EfCoreGenericRepository<Author>, IAuthorRepository
    {
        BooksAppContext _context = new BooksAppContext();

        public async Task CreateWithUrl(Author author)
        {
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            author.Url = author.Url + "-" + author.Id;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Author>> GetAllAuthorsAsync(bool isDeleted, bool? isActive = null)
        {
            var result = _context
                .Authors
                .Where(a => a.IsDeleted == isDeleted)
                .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(a => a.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }
    }
}
