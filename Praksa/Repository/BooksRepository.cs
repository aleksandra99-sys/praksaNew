using Praksa.Models;

namespace Praksa.Repository
{
    public class BooksRepository
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
    }
}
