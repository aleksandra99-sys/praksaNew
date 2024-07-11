using Microsoft.AspNetCore.Mvc;
using Praksa.Models;
using Praksa.Repository;

namespace Praksa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BooksRepository _booksRepository = new BooksRepository();
        


        [HttpGet]
        public List<Book> GetBooks()
        {
            return _booksRepository.Books;
            
        }

        [HttpGet("{id}")]
        public Book GetBookById(int id)
        {
            return _booksRepository.Books.Where(n => n.Id == id).FirstOrDefault();

        }

        [HttpPost]
        public Book PostBook(Book book)
        {
            _booksRepository.Books.Add(book);
            return book;
        }

        [HttpDelete("{id}")] 
        public void DeleteBook(int id)
        {
            var deleteBook = _booksRepository.Books.Where(n => n.Id == id).FirstOrDefault();
            _booksRepository.Books.Remove(deleteBook);
        }

        [HttpPut]
        public Book PutBook(Book book)
        {
            var editBook = _booksRepository.Books.FirstOrDefault(n => n.Id == book.Id);
            editBook.Id = book.Id;
            editBook.Name = book.Name;
            editBook.Author = book.Author;
            editBook.ReleaseDate = book.ReleaseDate;
            return editBook;
        }
    }
}
