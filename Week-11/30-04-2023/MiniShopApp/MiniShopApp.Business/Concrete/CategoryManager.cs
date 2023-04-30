using MiniShopApp.Business.Abstract;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Data.Concrete.EFCore.Repisotories;
using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository; //içi boþ olan _categoryRepository deðiþkeni. Bu program.cs'deki kodumuzla product repomuza iliþki kurmamýzý saðlýyor. Eðer product.cs'de bu kodu yazmasaydýk, kullanmak istediðimizde her defasýnda new yeni obje yaratmak zorunda kalacaktýk. Bu da performans için olumsuz bir durum.
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository; //burasý da constructorýmýz. burada categoryRepository nesnesini yukaruda iliþkilendirdiðimiz _categoryRepository'nin içine attýk.
        }
        public void Create(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll(); //Yukarýda oluþturulan _categoryRepository'e bir eylem verdik. GetAll metoduyla ürün bilgilerini çekiyoruz. ve geri döndürüyoruz(isteðe).
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoriesByProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
