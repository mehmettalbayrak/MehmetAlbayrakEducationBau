using BooksApp.Business.Abstract;
using BooksApp.Shared.ControllerBases;
using BooksApp.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BooksApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : CustomControllerBase
    {
        private readonly IBookService _bookManager;

        public BooksController(IBookService bookManager)
        {
            _bookManager = bookManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _bookManager.GetAllAsync();
            if (response.IsSucceeded)
            {
                var jsonResult = JsonSerializer.Serialize(response);
                return Ok(jsonResult);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _bookManager.GetByIdAsync(id);
            if (response.IsSucceeded)
            {
                var jsonResult = JsonSerializer.Serialize(response);
                return Ok(jsonResult);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Save(BookCreateDto bookCreateDto)
        {
            var response = await _bookManager.CreateAsync(bookCreateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }
    }
}
