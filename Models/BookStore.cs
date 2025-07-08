using QuantumBookstore.Interfaces;

namespace QuantumBookstore.Models
{
    static class BookStore
    {
        public static List<Book> Books = new();

        public static void DisplayAllBooks()
        {
            Console.WriteLine("All Books in the Inventory :- ");
            foreach (var book in Books)
            {
                if (book is PaperBook pbook)
                    Console.WriteLine(pbook);
                else if (book is EBook ebook)
                    Console.WriteLine(ebook);
                else
                    Console.WriteLine(book as ShowcaseBook);
            }
            Console.WriteLine();
        }

        public static void AddBook(Book book)
        {
            if (string.IsNullOrEmpty(book.ISBN))
                throw new ArgumentException("ISBN is required");
            Books.Add(book);
        }

        public static List<Book> RemoveOutdated(short maxPeriod)
        {
            List<Book> Outdated = Books.FindAll(book => (DateTime.Now.Year - book.PublishYear) > maxPeriod);

            Books.RemoveAll(book => (DateTime.Now.Year - book.PublishYear) > maxPeriod);

            return Outdated;
        }

        public static double BuyBook(string isbn, int quantity, string destination)
        {
            Book? book = Books.Find(b => b.ISBN == isbn);
            if (book == null)
                throw new Exception("Book with provided ISBN isn't available");

            if (book is IBuyable buyable)
                return buyable.Buy(quantity, destination);

            throw new Exception("Book with provided ISBN is not for sale");
        }
    }
}
