using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetHomePageProductsAsync();
        Task<List<Product>> GetActiveProductAsync(string categoryUrl);
        Task<Product> GetProductByUrlAsync(string url);
    }
}
