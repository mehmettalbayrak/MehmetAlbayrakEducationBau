using BooksApp.Data.Abstract;
using BooksApp.Data.Concrete.EFCore.Context;
using BooksApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete.EFCore.Repositories
{
    public class EFCoreCategoryRepository:EFCoreGenericRepository<Category>, ICategoryRepository
    {
        BooksAppContext _context = new BooksAppContext();

        public async Task<List<Category>> GetActiveCategoriesAsync()
        {
            var result = await _context
                .Categories
                .Where<c => c.>
            return result;
        }
    }
}
