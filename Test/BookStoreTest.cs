using QuantumBookstore.Models;

namespace QuantumBookstore.Test
{
    class BookStoreTest
    {
        public static void Run()
        {
            BookStore.Books.Clear();
            TestAdd();
            BookStore.DisplayAllBooks();
            TestRemoveOutdated();
            BookStore.DisplayAllBooks();
            TestBuyBooks();
            BookStore.DisplayAllBooks();
        }

        private static void TestAdd()
        {
            BookStore.AddBook(new PaperBook("100", "Paper Book", 2023, 25.5, 5));
            BookStore.AddBook(new EBook("200", "EBook", 2022, 15, FileType.pdf));
            BookStore.AddBook(new ShowcaseBook("300", "Showcase Book", 2023));
        }

        private static void TestRemoveOutdated()
        {
            BookStore.AddBook(new PaperBook("123", "Old Book", 2010, 40, 1));
            BookStore.DisplayAllBooks();


            int initCount = BookStore.Books.Count;
            var outdated = BookStore.RemoveOutdated(5);

            Console.WriteLine("\nFilteration Applied Successfully");
            Console.WriteLine($"Number of Books Removed = {initCount - BookStore.Books.Count}\n");
        }

        private static void TestBuyBooks()
        {
            try
            {
                double amount = BookStore.BuyBook("100", 2, "Fayoum");
                Console.WriteLine($"Bought paper book for ${amount}");

                amount = BookStore.BuyBook("200", 1, "muhammednadyii@gmail.com");
                Console.WriteLine($"Bought ebook for ${amount}");

                Console.WriteLine();
            }
            catch (Exception ex) { Console.WriteLine($"ERROR during purchase"); }
        }
    }
}
