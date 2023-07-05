using Microsoft.AspNetCore.Mvc;

namespace BooksApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //localhost:3200/api/home
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return null;
        }
    }
}
