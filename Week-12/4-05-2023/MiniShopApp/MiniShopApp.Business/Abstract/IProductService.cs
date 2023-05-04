using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Abstract
{
    public interface IProductService
    {
        #region Generic
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task CreateAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
        #endregion

        #region Special
        Task<List<Product>> GetHomePageProductsAsync();
        Task<List<Product>> GetActiveProductsAsync();
        Task<Product> GetProductByUrlAsync(string url);
        #endregion
    }
}
