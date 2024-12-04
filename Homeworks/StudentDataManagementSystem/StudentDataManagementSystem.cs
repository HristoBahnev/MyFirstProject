internal class StudentDataManagementSystem
{
    static List<string> subjects = new List<string> { "Math", "Biology", "History", "English", "Sport", "Physics" };
    static Dictionary<string, Dictionary<string, List<double>>> students = new Dictionary<string, Dictionary<string, List<double>>>();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Student Data Management System!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a new student");
            Console.WriteLine("2. Remove a student");
            Console.WriteLine("3. Assign student to subject");
            Console.WriteLine("4. Update a student's grades");
            Console.WriteLine("5. Display all students");
            Console.WriteLine("6. Exit");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    RemoveStudent();
                    break;
                case "3":
                    AssignStudentToSubject();
                    break;
                case "4":
                    UpdateStudentsGrade();
                    break;
                case "5":
                    DisplayAllStudents();
                    break;
                case "6":
                    Console.WriteLine("Exiting the system. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid number.");
                    break;
            }
        }
    }
    private static void AddStudent()
    {
        Console.WriteLine("Enter student name: ");
        string name = Console.ReadLine();
        students[name] = new Dictionary<string, List<double>>();

        Console.WriteLine($"Student {name} added successfully!");
    }

    private static void RemoveStudent()
    {
        Console.WriteLine("Enter student name to remove: ");
        string name = Console.ReadLine();
        students.Remove(name);
    }
    private static void AssignStudentToSubject()
    {
        Console.WriteLine("Enter student and subject: ");
        string input = Console.ReadLine();
        var nameAndSubject = input.Split("-");
        string name = nameAndSubject[0];
        string subject = nameAndSubject[1];

        students[name][subject] = new List<double>();

    }

    private static void UpdateStudentsGrade()
    {
        Console.WriteLine("Enter student's name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter subject name and grade in the format {Subject name}-{grade}: ");
        string input = Console.ReadLine();
        var subjectAndGrade = input.Split("-");
        string subject = subjectAndGrade[0];
        double grade = double.Parse(subjectAndGrade[1]);
        students[name][subject].Add(grade);
    }

    private static void DisplayAllStudents()
    {

        foreach (var student in students)
        {
            string name = student.Key;
            var subject = student.Value;
            var grade = subject.Keys.
        }

    }
}