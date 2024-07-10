namespace Praksa.Models
{
    public static class BooksRepository
    {
        public static List<Book> Books { get; set; } = new List<Book>()
        {
                new Book
                {
                    Id = 1,
                    Name = "Pride and Prejudice",
                    Author = "Jane Austin",
                    ReleaseDate = 1813
                },
                new Book
                {
                    Id = 2,
                    Name = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    ReleaseDate = 1960
                },
                new Book
                {
                    Id = 3,
                    Name = "The Great Gatsby",
                    Author = "Scott Fitzgerald",
                    ReleaseDate = 1925
                }
        };
    }
}
