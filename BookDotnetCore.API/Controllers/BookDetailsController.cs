using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookDotnetCore.BAL.services;
using BookDotnetCore.Entity;

namespace BookDotnetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookDetailsController : ControllerBase
    {
        private BookDetailsService _bookDetailsService;
        public BookDetailsController(BookDetailsService bookDetailsService)
        {
            _bookDetailsService = bookDetailsService;
        }
        [HttpPost]

        public IActionResult SaveBook(BookDetails bookDetails)
        {
            return Ok(_bookDetailsService.SaveBook(bookDetails));
        }
    }
}

//swagger:needed to run api services
//postman:
