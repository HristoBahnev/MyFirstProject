namespace AdvancedLibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<LibraryItem> library = new List<LibraryItem>
        {
            new Book("Barbapapa", "Annette Tison"),
            new Book("Patilantsi", "Ran Bosilek"),
            new Magazine("Playboy", 111),
            new Magazine("Maxim", 222)
        };

            Dictionary<string, int> borrowerLimits = new Dictionary<string, int>();

            void BorrowItem(LibraryItem item, string borrower, DateTime dueDate)
            {
                if (!borrowerLimits.ContainsKey(borrower))
                    borrowerLimits[borrower] = 0;

                if (borrowerLimits[borrower] >= 3)
                {
                    Console.WriteLine($"{borrower} cannot borrow more than 3 items at once.");
                    return;
                }

                item.Borrow(borrower, dueDate);
                if (item.IsBorrowed)
                    borrowerLimits[borrower]++;
            }

            void ReturnItem(LibraryItem item, string borrower)
            {
                if (item.IsBorrowed && item.Borrower == borrower)
                {
                    item.Return();
                    borrowerLimits[borrower]--;
                }
                else
                {
                    Console.WriteLine($"Error: {borrower} cannot return '{item.Title}' as it is not borrowed by them.");
                }
            }

            BorrowItem(library[0], "Ivan", DateTime.Now.AddDays(1));
            BorrowItem(library[1], "Ivan", DateTime.Now.AddDays(2));
            BorrowItem(library[2], "Ivan", DateTime.Now.AddDays(3));
            BorrowItem(library[3], "Ivan", DateTime.Now.AddDays(4));
            BorrowItem(library[3], "Georgi", DateTime.Now.AddDays(5));
            ReturnItem(library[0], "Ivan");

            Console.WriteLine("Library Status:");
            foreach (var item in library)
            {
                item.CheckStatus();
            }
        }
    }
}
