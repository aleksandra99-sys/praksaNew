using Praksa.Controllers;
using Praksa.Models;

namespace Praksa.Repository
{
    public class BooksRepository : IBooks
    {
        
        public List<Book> Books { get; set; } = new List<Book>()
        {
                new Book
                {
                    Id = 1,
                    Name = "Pride and Prejudice",
                    Author = "Jane Austin",
                    ReleaseDate = new DateTime(1813, 1, 28)
                },
                new Book
                {
                    Id = 2,
                    Name = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    ReleaseDate = new DateTime(1960, 7, 11)
                },
                new Book
                {
                    Id = 3,
                    Name = "The Great Gatsby",
                    Author = "Scott Fitzgerald",
                    ReleaseDate = new DateTime(1925, 4, 10)
                }
        };

        public void DeleteBook(int id)
        {
            var deleteBook = Books.Where(n => n.Id == id).FirstOrDefault();
            Books.Remove(deleteBook);
        }

        public Book GetBookById(int id)
        {
            return Books.Where(n => n.Id == id).FirstOrDefault();
        }

        public List<Book> GetBooks()
        {
            return Books;
        }

        public Book PostBook(Book book)
        {
            Books.Add(book);
            return book;
        }

        public Book PutBook(Book book)
        {
            var editBook =Books.FirstOrDefault(n => n.Id == book.Id);
            editBook.Id = book.Id;
            editBook.Name = book.Name;
            editBook.Author = book.Author;
            editBook.ReleaseDate = book.ReleaseDate;
            return editBook;
        }
    }
}
