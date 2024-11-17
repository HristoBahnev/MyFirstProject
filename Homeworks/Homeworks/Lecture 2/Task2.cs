namespace Homeworks.Lecture_2
{
    class Task2
    {
        public void FormatAFullName()
        {
            //Objective: Ask the user to enter their first name and last name, then combine and display them in the format "Last Name, First Name."
            //Instructions: Use string concatenation or interpolation to format the name.
            
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"{lastName}, {firstName}");
        }
    }
}