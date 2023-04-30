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
        private readonly ICategoryRepository _categoryRepository; //i�i bo� olan _categoryRepository de�i�keni. Bu program.cs'deki kodumuzla product repomuza ili�ki kurmam�z� sa�l�yor. E�er product.cs'de bu kodu yazmasayd�k, kullanmak istedi�imizde her defas�nda new yeni obje yaratmak zorunda kalacakt�k. Bu da performans i�in olumsuz bir durum.
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository; //buras� da constructor�m�z. burada categoryRepository nesnesini yukaruda ili�kilendirdi�imiz _categoryRepository'nin i�ine att�k.
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
            return _categoryRepository.GetAll(); //Yukar�da olu�turulan _categoryRepository'e bir eylem verdik. GetAll metoduyla �r�n bilgilerini �ekiyoruz. ve geri d�nd�r�yoruz(iste�e).
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
