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

        [HttpGet("{id}")]
        public Book GetBookById(int id)
        {
            return BooksRepository.Books.Where(n => n.Id == id).FirstOrDefault();

        }

        [HttpPost]
        public Book PostBook(Book book)
        {
            BooksRepository.Books.Add(book);
            return book;
        }

        [HttpDelete("{id}")] 
        public void DeleteBook(int id)
        {
            var deleteBook = BooksRepository.Books.Where(n => n.Id == id).FirstOrDefault();
            BooksRepository.Books.Remove(deleteBook);
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
