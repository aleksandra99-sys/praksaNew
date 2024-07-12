using Praksa.Models;

namespace Praksa.Repository
{
    public interface IBooks
    {
        public void DeleteBook(int id);
        public Book PutBook(Book book);
        public Book PostBook(Book book);
        public Book GetBookById(int id);
        public List<Book> GetBooks();
    }
}
