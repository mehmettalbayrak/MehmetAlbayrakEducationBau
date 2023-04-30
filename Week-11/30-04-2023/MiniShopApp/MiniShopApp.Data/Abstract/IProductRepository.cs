using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        List<Product> GetHomePageProducts(int id);
    }
}
