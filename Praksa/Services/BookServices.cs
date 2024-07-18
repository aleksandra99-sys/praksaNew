using Praksa.Exceptions;
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
                throw new NotFoundException($"Book with id {id} was not found");
            }
            _booksRepository.DeleteBook(id);
        }

        public Book GetBookById(int id)
        {
            var book = _booksRepository.GetBookById(id);
            if (book == null)
            {
                throw new NotFoundException($"Book with id {id} was not found");
            }
            return book;
        } 

        public List<Book> GetBooks()
        {
            return _booksRepository.GetBooks();
        }

        public Book PostBook(Book book)
        {
            var bookList = _booksRepository.GetBooks();
            for (int i = 0; i < bookList.Count; i++)
            {
                Console.WriteLine(bookList[i]);
                if (bookList[i].Name == book.Name && bookList[i].Author == book.Author)
                {
                    throw new ForbiddenException("Knjiga vec postoji"); //Ovde je mogao 409 Conflict
                }
            }
           return _booksRepository.PostBook(book);
        }

        public Book PutBook(Book book)
        {
            var books = _booksRepository.GetBookById(book.Id);
            if (books == null)
            {
                throw new NotFoundException($"Book with id {book.Id} was not found"); 
            }
            return _booksRepository.PutBook(book);
        }

    }
}
