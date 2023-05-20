using BooksApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Task<List<Category>> GetAllNondeletedCategoriesAsync(bool isDeleted, bool? isActive=null); //true gösterirsek deleted gösterir false ise undeleted. isActive için de aynısı geçerli.
    }
}
