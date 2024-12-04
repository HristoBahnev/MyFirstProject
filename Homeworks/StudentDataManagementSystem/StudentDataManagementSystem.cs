class StudentDataManagementSystem
{
    static List<string> subjects = new List<string> { "Math", "Biology", "History", "English", "Sport", "Physics" };
    static Dictionary<string, Dictionary<string, List<double>>> students = new Dictionary<string, Dictionary<string, List<double>>>();

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Student Data Management System!");

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a new student");
            Console.WriteLine("2. Remove a student");
            Console.WriteLine("3. Assign student to subject");
            Console.WriteLine("4. Update a student's grades");
            Console.WriteLine("5. Display all students");
            Console.WriteLine("6. Exit\n");
            Console.Write("Enter your choice: ");
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
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }

    private static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        if (students.ContainsKey(name))
        {
            Console.WriteLine("Student already exists.\n");
            return;
        }

        students[name] = new Dictionary<string, List<double>>();

        Console.WriteLine($"Student {name} added successfully!\n");
    }

    private static void RemoveStudent()
    {
        Console.Write("Enter student name to remove: ");
        string name = Console.ReadLine();

        if (!students.ContainsKey(name))
        {
            Console.WriteLine("Student not found.\n");
            return;
        }

        students.Remove(name);
        Console.WriteLine($"Student {name} removed successfully!\n");
    }

    private static void AssignStudentToSubject()
    {
        Console.Write("Enter student and subject (e.g., John Doe-Math): ");
        string input = Console.ReadLine();
        string[] nameAndSubject = input.Split("-");

        if (nameAndSubject.Length != 2)
        {
            Console.WriteLine("Invalid format. Please use 'StudentName-Subject'.\n");
            return;
        }

        string name = nameAndSubject[0];
        string subject = nameAndSubject[1];

        if (!students.ContainsKey(name))
        {
            Console.WriteLine($"Student '{name}' not found.\n");
            return;
        }

        if (!subjects.Contains(subject))
        {
            Console.WriteLine($"Invalid subject. Valid subjects are {string.Join(", ", subjects)}.\n");
            return;
        }

        if (students[name].ContainsKey(subject))
        {
            Console.WriteLine($"Student '{name}' is already enrolled in {subject}.\n");
            return;
        }

        students[name][subject] = new List<double>();

        Console.WriteLine($"Student '{name}' has successfully enrolled in {subject} class.\n");
    }

    private static void UpdateStudentsGrade()
    {
        Console.Write("Enter student's name: ");
        string name = Console.ReadLine();

        if (!students.ContainsKey(name))
        {
            Console.WriteLine($"Student '{name}' not found.\n");
            return;
        }

        Console.Write("Enter subject and grade in the format {Subject name}-{grade}: ");
        string input = Console.ReadLine();
        var subjectAndGrade = input.Split("-");

        if (subjectAndGrade.Length != 2)
        {
            Console.WriteLine("Invalid format. Please use {Subject name}-{grade}.\n");
            return;
        }

        string subject = subjectAndGrade[0];
        double grade;

        if (!double.TryParse(subjectAndGrade[1], out grade))
        {
            Console.WriteLine("Invalid grade. Please enter a valid number.\n");
            return;
        }

        if (grade < 2 || grade > 6)
        {
            Console.WriteLine("Grade must be between 2 and 6.");
            return;
        }

        if (!subjects.Contains(subject))
        {
            Console.WriteLine("Invalid subject. Valid subjects are Math, Biology, History, English, Sport, Physics.\n");
            return;
        }

        if (!students[name].ContainsKey(subject))
        {
            Console.WriteLine($"Student '{name}' is not enrolled in {subject}.\n");
            return;
        }

        students[name][subject].Add(grade);
        Console.WriteLine($"Grade {grade} added for {subject}.\n");
    }

    private static void DisplayAllStudents()
    {
        Console.WriteLine("Displaying all students:\n");

        foreach (var student in students)
        {
            string name = student.Key;
            var subjectsAndGrades = student.Value;

            Console.WriteLine($"{name}, Subjects:");

            foreach (var subject in subjectsAndGrades)
            {
                double averageGrade = subject.Value.Any() ? subject.Value.Average() : 0;
                Console.WriteLine($"{subject.Key}: {string.Join(", ", subject.Value)} (Average Grade: {averageGrade:F2})");
            }
            Console.WriteLine();
        }
    }
}
