using AutoMapper;
using BooksApp.Business.Abstract;
using BooksApp.Data.Abstract;
using BooksApp.Entity.Concrete;
using BooksApp.Shared.DTOs;
using BooksApp.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<CategoryDto>>> GetAllAsync()
        {
            //Bu metot geriye bir response döndürecek.
            //Önce tüm kategorileri veri tabanından çek.
            var categoryList = await _categoryRepository.GetAllAsync();
            //Gelen Category listesini CategoryDto Listesine dönüştür.
            return Response<>
        }

        public Task<Response<CategoryDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateAsync(CategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
