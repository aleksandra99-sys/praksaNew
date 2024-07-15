using Praksa.Models;
using Praksa.Repository;

namespace Praksa.Services
{
    public class BookServices : IBookServices
    {

        private IBooksRepository _books;

        public BookServices(IBooksRepository books)
        {
            _books = books;
        }

        public void DeleteBook(int id)
        {
            _books.DeleteBook(id);
        }

        public Book GetBookById(int id)
        {
            return _books.GetBookById(id);
        }

        public List<Book> GetBooks()
        {
            return _books.GetBooks();
        }

        public Book PostBook(Book book)
        {
           return _books.PostBook(book);
        }

        public Book PutBook(Book book)
        {
            return _books.PutBook(book);
        }
    }
}
