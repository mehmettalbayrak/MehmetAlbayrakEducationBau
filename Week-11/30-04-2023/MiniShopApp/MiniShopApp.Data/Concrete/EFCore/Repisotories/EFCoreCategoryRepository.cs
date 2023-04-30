using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore.Repisotories
{
    public class EFCoreCategoryRepository : EFCoreGenericRepisotory<Category>, ICategoryRepository
    {
        public List<Category> GetCategoriesByProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
