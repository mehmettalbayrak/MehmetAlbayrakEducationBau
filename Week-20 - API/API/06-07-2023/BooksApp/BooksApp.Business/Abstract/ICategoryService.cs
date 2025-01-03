﻿using BooksApp.Entity.Concrete;
using BooksApp.Shared.DTOs;
using BooksApp.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Business.Abstract
{
    public interface ICategoryService
    {
        #region Generic
        Task<Response<CategoryDto>> GetByIdAsync(int id);
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(CategoryCreateDto categorCreateDto);
        Task<Response<NoContent>> UpdateAsync(CategoryDto categoryDto);
        Task<Response<NoContent>> Delete(int id);
        #endregion
      
    }
}
