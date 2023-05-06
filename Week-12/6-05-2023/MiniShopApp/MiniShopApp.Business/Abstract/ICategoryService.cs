using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Abstract
{
    public interface ICategoryService
    {
        #region Generic
        Task<Category> GetByIdAsync(int id);
        Task<List<Category>> GetAllAsync();
        Task CreateAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(Category category);
        #endregion

        #region Special
        Task<List<Category>> GetCategoriesByProductAsync(int productId);
        Task<List<Category>> GetActiveCategoriesAsync();
        
        #endregion

    }
}
