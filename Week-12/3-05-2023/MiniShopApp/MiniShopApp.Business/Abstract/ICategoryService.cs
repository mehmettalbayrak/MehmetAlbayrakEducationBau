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
        Category GetById(int id);
        List<Category> GetAll();
        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);
        #endregion

        #region Special
        List<Category> GetCategoriesByProduct(int productId);
        Task<List<Category>> GetActiveCategoriesAsync();
        
        #endregion

    }
}
