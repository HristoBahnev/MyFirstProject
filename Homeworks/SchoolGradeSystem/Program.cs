namespace SchoolGradeSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IGradeCalculator> GradeCalculator = new List<IGradeCalculator>
        {
            new Assignment(100, 85),
            new Exam(60,55)
        }; 

            foreach (var item in GradeCalculator)
            {
                Console.WriteLine($"{item.GetType().Name} Grade: {item.CalculateGrade():F2}%");
            }
        }
    }
}
