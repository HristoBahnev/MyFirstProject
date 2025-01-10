namespace AdvancedLibraryManagementSystem
{
    public abstract class LibraryItem : IBorrowable
    {
        private string _title;
        private bool _isBorrowed;
        private string _borrower;
        private DateTime _dueDate;

        public LibraryItem(string title)
        {
            _title = title;
        }
        public string Title
        {
            get { return _title; }
            private set { _title = value; }
        }

        public bool IsBorrowed
        {
            get { return _isBorrowed; }
            private set { _isBorrowed = value; }
        }

        public string Borrower
        {
            get { return _borrower; }
            private set { _borrower = value; }
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            private set { _dueDate = value; }
        }


        public void CheckSum()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"Title: {Title}, Borrowed by {Borrower}, Due on {DueDate}");
            }
            else
            {
                Console.WriteLine($"Title: {Title}, Available for borrowing.");
            }
        }

        public void ExtendDueDate(int days)
        {
            if (IsBorrowed)
            {
                DueDate = DueDate.AddDays(days);
            }
        }

        public void CheckStatus()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"Title: {Title}, Borrowed by {Borrower}, Due on {DueDate:yyyy-MM-dd}.");
            }
            else
            {
                Console.WriteLine($"Title: {Title}, Available for borrowing.");
            }
        }

        public virtual void Borrow(string borrower, DateTime dueDate)
        {
            IsBorrowed = true;
            Borrower = borrower;
            DueDate = dueDate;
        }

        public virtual void Return()
        {
            IsBorrowed = false;
        }

        Dictionary<string, int> borrowerLimits = new Dictionary<string, int>();

        public void BorrowItem(string borrower, DateTime dueDate)
        {
            if (!borrowerLimits.ContainsKey(borrower))
                borrowerLimits[borrower] = 0;

            if (borrowerLimits[borrower] >= 3)
            {
                Console.WriteLine($"{borrower} cannot borrow more than 3 items at once.");
                return;
            }

            Borrow(borrower, dueDate);
            if (IsBorrowed)
                borrowerLimits[borrower]++;
        }

        public void ReturnItem(string borrower)
        {
            if (IsBorrowed && Borrower == borrower)
            {
                Return();
                borrowerLimits[borrower]--;
            }
            else
            {
                Console.WriteLine($"Error: {borrower} cannot return '{Title}' as it is not borrowed by them.");
            }
        }
    }
}