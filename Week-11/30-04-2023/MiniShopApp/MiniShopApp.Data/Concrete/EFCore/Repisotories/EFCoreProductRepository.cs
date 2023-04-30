using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore.Repisotories
{
    public class EFCoreProductRepository : EFCoreGenericRepisotory<Product>, IProductRepository
    {
        public List<Product> GetHomePageProducts(int id)
        {
            throw new NotImplementedException();
        }
    }
}
