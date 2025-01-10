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

            library[0].BorrowItem("Ivan", DateTime.Now.AddDays(1));
            library[1].BorrowItem("Ivan", DateTime.Now.AddDays(2));
            library[2].BorrowItem("Ivan", DateTime.Now.AddDays(3));
            library[3].BorrowItem("Ivan", DateTime.Now.AddDays(4));
            library[3].BorrowItem("Georgi", DateTime.Now.AddDays(5));
            library[0].ReturnItem("Ivan");

            Console.WriteLine("Library Status:");
            foreach (var item in library)
            {
                item.CheckStatus();
            }
        }
    }
}
