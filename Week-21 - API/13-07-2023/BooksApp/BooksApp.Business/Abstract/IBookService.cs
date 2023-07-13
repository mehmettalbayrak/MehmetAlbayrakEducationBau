using BooksApp.Entity.Concrete;
using BooksApp.Shared.DTOs;
using BooksApp.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Business.Abstract
{
    public interface IBookService
    {
        #region Generic
        Task<Response<BookDto>> GetByIdAsync(int id);
        Task<Response<List<BookDto>>> GetAllAsync();
        Task<Response<BookDto>> CreateAsync(BookCreateDto bookCreateDto);
        Task<Response<NoContent>> UpdateAsync(BookUpdateDto bookUpdateDto);
        Task<Response<NoContent>> DeleteAsync(int id);
        #endregion

    }
}
