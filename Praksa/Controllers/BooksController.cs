using Microsoft.AspNetCore.Mvc;
using Praksa.Models;
using Praksa.Services;

namespace Praksa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase 
    {
        private IBookServices _bookServices;

        public BooksController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }


        [HttpGet]
      public List<Book> GetBooks()
       {
          return _bookServices.GetBooks(); 
        }

        [HttpGet("{id}")]
        public Book GetBookById(int id)
        {
            return _bookServices.GetBookById(id);
        }

        [HttpPost]
        public Book PostBook(Book book)
        {
            return _bookServices.PostBook(book);
        }

        [HttpDelete("{id}")]
        public void DeleteBook(int id)
        {
            _bookServices.DeleteBook(id);
        }
            

        [HttpPut]
        public Book PutBook(Book book)
        {
            return _bookServices.PutBook(book);
        }
    }
}
