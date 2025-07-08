using QuantumBookstore.Services;
using QuantumBookstore.Interfaces;

namespace QuantumBookstore.Models
{
    enum FileType { pdf, txt, html, epub }
    class EBook : Book , IBuyable
    {
        public FileType fileType { get; set; }
        public EBook(string isbn, string title, short year, double price, FileType type) : base(isbn, title, year, price) { fileType = type; }

        public double Buy(int quantity, string email)
        {
            if (quantity != 1)
                throw new ArgumentException("Only one eBook can be bought at a time");
            MailService.ApplyService(this, email);
            return Price;
        }

        public override string ToString() { return $"ISBN: {ISBN}, Title: {Title}, PublishYear: {PublishYear}, File Type: {fileType.ToString()}, Price: {Price}"; }
    }
}
