using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Abstract
{
    //Şu an bu Interface IGenericRepository'den Category Tipi için mirias alarak oluştuğundan dolayı; bunun içinde IGenericRepository'deki tüm metodların Category'e göre oluşmuş imzaları mevcuttur. Sadece burası da interface olduğu için burada gözükmemektedir.
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        List<Category> GetCategoriesByProduct(int productId);
        Task<List<Category>> GetActiveCategoriesAsync();
    }
}
