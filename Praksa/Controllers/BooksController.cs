using Microsoft.AspNetCore.Mvc;
using Praksa.Models;
using Praksa.Repository;

namespace Praksa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase 
    {
        private IBooks _booksRepository;

        public BooksController(IBooks booksRepository)
        {
            _booksRepository = booksRepository;
        }


        [HttpGet]
      public List<Book> GetBooks()
       {
          return _booksRepository.GetBooks(); 
        }

        [HttpGet("{id}")]
        public Book GetBookById(int id)
        {
            return _booksRepository.GetBookById(id);
        }

        [HttpPost]
        public Book PostBook(Book book)
        {
            return _booksRepository.PostBook(book);
        }

        [HttpDelete("{id}")]
        public void DeleteBook(int id)
        {
            _booksRepository.DeleteBook(id);
        }
            

        [HttpPut]
        public Book PutBook(Book book)
        {
            return _booksRepository.PutBook(book);
        }
    }
}
