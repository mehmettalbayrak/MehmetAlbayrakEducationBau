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
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart>, ICartRepository
    {
        public EfCoreCartRepository(BooksAppContext _appContext):base(_appContext)
        {
            
        }
        BooksAppContext AppContext
        {
            get { return _dbContext as BooksAppContext; }
        }

        public async Task<Cart> GetCartByUserId(string userId)
        {
            var result = await AppContext
                .Carts
                .Where(c => c.UserId == userId)
                .Include(c=>c.CartItems)
                .ThenInclude(ci=>ci.Book)
                .FirstOrDefaultAsync();
            return result;
        }
    }
}
