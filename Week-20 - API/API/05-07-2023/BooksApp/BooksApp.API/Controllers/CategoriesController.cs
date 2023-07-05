using BooksApp.Business.Abstract;
using BooksApp.Entity.Concrete;
using BooksApp.Shared.ControllerBases;
using BooksApp.Shared.DTOs;
using BooksApp.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BooksApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomControllerBase
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
            var jsonResult = JsonSerializer.Serialize(categoryList);
            var result = CreateActionResult(Response<List<Category>>.Success(categoryList, 200));

            return Ok(jsonResult);
        }
    }
}
