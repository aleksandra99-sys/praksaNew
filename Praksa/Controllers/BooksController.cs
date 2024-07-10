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

        [HttpDelete("id:int")] //Index krece od nule, ako stavim id = 2 izbrisace se knjiga za koju pise da ima id = 3
        public void DeleteBook(int id)
        {
            BooksRepository.Books.RemoveAt(id);
        }

        [HttpPut]
        public Book PutBook(Book book)
        {
            var editBook = BooksRepository.Books.FirstOrDefault(n => n.Id == book.Id);
            editBook.Id = book.Id;
            editBook.Name = book.Name;
            editBook.Author = book.Author;
            editBook.ReleaseDate = book.ReleaseDate;
            return editBook;
        }
    }
}
