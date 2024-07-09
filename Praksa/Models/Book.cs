﻿namespace Praksa.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Author Author { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
