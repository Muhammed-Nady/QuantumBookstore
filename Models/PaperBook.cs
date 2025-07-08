using QuantumBookstore.Services;

namespace QuantumBookstore.Models
{
    class PaperBook : Book
    {
        public int Stock { get; set; }
        public PaperBook(string isbn, string title, short year, double price, int stock = 0) : base(isbn, title, year, price) { Stock = stock; }

        public double Buy(int quantity, string address)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity can't be non-positive number");
            if (Stock < quantity)
                throw new Exception("Required Quantity isn't available in the Stock");

            Stock -= quantity;
            ShippingService.ApplyService(this, address, quantity);

            return quantity * Price;
        }
        public override string ToString() { return $"ISBN: {ISBN}, Title: {Title}, PublishYear: {PublishYear}, Available Quantity: {Stock}, Price: {Price}"; }
    }
}
