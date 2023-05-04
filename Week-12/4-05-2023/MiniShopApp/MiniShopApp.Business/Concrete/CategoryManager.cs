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
        public async Task CreateAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetActiveCategoriesAsync()
        {
            return await _categoryRepository.GetActiveCategoriesAsync();
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _categoryRepository.GetAllAsync(); //Yukar�da olu�turulan _categoryRepository'e bir eylem verdik. GetAll metoduyla �r�n bilgilerini �ekiyoruz. ve geri d�nd�r�yoruz(iste�e).
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategoriesByProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
