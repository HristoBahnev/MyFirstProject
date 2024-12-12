namespace AdvancedLibraryManagementSystem
{
    public interface IBorrowable
    {
        void Borrow(string borrower, DateTime dueDate);
        void Return();

    }
}
