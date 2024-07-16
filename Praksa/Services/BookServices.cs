using Praksa.Models;
using Praksa.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace Praksa.Services
{
    public class BookServices : IBookServices
    {

        private IBooksRepository _booksRepository;

        public BookServices(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public void DeleteBook(int id)
        {
            var book = _booksRepository.GetBookById(id);
            if (book == null) 
            {
                throw new Exception($"Book with id {id} was not found");
            }
            _booksRepository.DeleteBook(id);
        }

        public Book GetBookById(int id)
        {
            var book = _booksRepository.GetBookById(id);
            if (book == null)
            {
                throw new Exception($"Book with id {id} was not found");
            }
            return book;
        } 

        public List<Book> GetBooks()
        {
            return _booksRepository.GetBooks();
        }

        public Book PostBook(Book book)
        {
           return _booksRepository.PostBook(book);
        }

        public Book PutBook(Book book)
        {
            if(book.Id == null)
            {
                throw new Exception($"Book with id was not found");
            }
            return _booksRepository.PutBook(book);
        }

    }
}
