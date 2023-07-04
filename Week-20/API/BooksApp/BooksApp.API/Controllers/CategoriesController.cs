using BooksApp.Business.Abstract;
using BooksApp.Shared.DTOs;
using BooksApp.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categoryList = await _categoryManager.GetAllAsync();
            return null;
        }
    }
}
