namespace AdvancedLibraryManagementSystem
{
    public class Magazine : LibraryItem
    {
        private int _issueNumber;

        public Magazine(string title, int issueNumber) : base(title)
        {
            _issueNumber = issueNumber;
        }
        public int IssueNumber
        {
            get { return _issueNumber; }
            private set { _issueNumber = value; }
        }

        public override void Borrow(string borrower, DateTime dueDate)
        {
            base.Borrow(borrower, dueDate);
            if (IsBorrowed)
            {
                Console.WriteLine($"Magazine '{Title}' (Issue {IssueNumber}) borrowed by {Borrower}, due on {DueDate:yyyy-MM-dd}.");
            }
        }
    }
}
