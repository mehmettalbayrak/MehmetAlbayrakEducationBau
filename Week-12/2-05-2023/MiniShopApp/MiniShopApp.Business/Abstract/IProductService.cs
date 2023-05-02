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
        Product GetById(int id);
        List<Product> GetAll();
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);
        #endregion

        #region Special
        Task<List<Product>> GetHomePageProductsAsync();
        #endregion
    }
}
