using Praksa.Models;

namespace Praksa.Services
{
    public interface IBooksRepository
    {
        public void DeleteBook(int id);
        public Book PutBook(Book book);
        public Book PostBook(Book book);
        public Book GetBookById(int id);
        public List<Book> GetBooks();
    }
}
