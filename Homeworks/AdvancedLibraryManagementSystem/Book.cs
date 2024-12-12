namespace AdvancedLibraryManagementSystem
{
    public class Book : LibraryItem
    {
        private string _author;

        public Book(string title, string author) : base(title)
        {
            _author = author;
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public override void Borrow(string borrower, DateTime dueDate)
        {
            base.Borrow(borrower, dueDate);
            if (IsBorrowed)
            {
                Console.WriteLine($"Book '{Title}' by {Author} borrowed by {Borrower}, due on {DueDate:yyyy-MM-dd}.");
            }
        }
    }
}
