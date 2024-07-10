using Microsoft.AspNetCore.Mvc;
using Praksa.Models;

namespace Praksa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public List<Book> GetBooks()
        {
            return BooksRepository.Books; 
            
        }

        [HttpGet("id:int")]
        public Book GetBookById(int id)
        {
            return BooksRepository.Books.Where(n => n.Id == id).FirstOrDefault();

        }

        [HttpPost]
        public void PostBook(Book book)
        {
            BooksRepository.Books.Add(book);
        }
    }
}
