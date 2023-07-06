using BooksApp.Business.Abstract;
using BooksApp.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : CustomControllerBase
    {
        private readonly IPublisherService _publisherManager;

        public PublishersController(IPublisherService publisherManager)
        {
            _publisherManager = publisherManager;
        }

        [HttpGet]

    }
}
