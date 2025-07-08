namespace QuantumBookstore.Models
{
    class ShowcaseBook : Book
    {
        public ShowcaseBook(string isbn, string title, short year) : base(isbn, title, year, 0) { }

        public override string ToString() { return $"ISBN: {ISBN}, Title: {Title}, PublishYear: {PublishYear}"; }

    }
}
