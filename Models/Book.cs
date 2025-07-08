namespace QuantumBookstore.Models
{
    abstract class Book
    {
        public string ISBN { get; }
        public string Title { get; }
        public short PublishYear { get; }
        public double Price { get; }

        public Book(string isbn, string title, short year, double price)
        {
            ISBN = isbn;
            Title = title;
            PublishYear = year;
            Price = price;
        }
    }
}
