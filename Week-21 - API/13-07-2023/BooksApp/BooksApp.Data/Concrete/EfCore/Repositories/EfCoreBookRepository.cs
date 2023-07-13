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
        public EfCoreBookRepository(BooksAppContext _context) : base(_context)
        {

        }

        private BooksAppContext Context
        {
            get { return _dbContext as BooksAppContext; }
        }

        public async Task<bool> AnyAsync(int id)
        {
            return await Context
                .Books
                .AnyAsync(x => x.Id == id);
        }
    }
}
