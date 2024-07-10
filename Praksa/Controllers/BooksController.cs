using Microsoft.AspNetCore.Mvc;
using Praksa.Models;

namespace Praksa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]

        public List<Book> Books()
        {
            return BooksRepository.Books; 
            
        }
    }
}
