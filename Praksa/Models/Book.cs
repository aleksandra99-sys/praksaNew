namespace Praksa.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public string Autor { get; set; }

        public DateTime datumIzdavanja { get; set; }
    }
}
