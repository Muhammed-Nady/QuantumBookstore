## Features

- Supports multiple book types:
  - PaperBook: can be bought and shipped
  - EBook: can be bought and sent via email
  - ShowcaseBook: demo books that are not for sale
- Add new books to the inventory
- Remove outdated books that exceed a certain number of years
- Buy a book using ISBN, quantity, and destination (address or email)
- Routes purchased books to:
  - ShippingService (for PaperBook)
  - MailService (for EBook)

## Example Output
![image](https://github.com/user-attachments/assets/59641463-e462-4aad-84da-81c1e02a6322)


## How to Run

1. Clone the repository:
   git clone https://github.com/Muhammed-Nady/QuantumBookstore.git

2. Open the solution in Visual Studio or navigate to the project folder and run:
   dotnet run

3. The `BookStoreTest` class runs automatically and shows:
   - Inventory before and after removing outdated books
   - Purchase of a PaperBook and EBook
   - Final inventory state

## Author

Created by Mohammed Nady.
