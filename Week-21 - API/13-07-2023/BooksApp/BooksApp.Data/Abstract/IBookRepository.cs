using BooksApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Abstract
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<bool> AnyAsync(int id);
    }
}
