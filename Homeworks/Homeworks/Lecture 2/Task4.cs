namespace Homeworks.Lecture_2
{
    class Task4
    {
        public void CalculateTheAreaOfACircle()
        {
            //Objective: Prompt the user to input the radius as a string, convert it to a double, and calculate the area using the formula π* radius *radius.
            //Instructions: Use double.Parse() and math operations.Display the result as a formatted string with two decimal places.

            Console.WriteLine("Enter a radius:");
            string radiusInput = Console.ReadLine();
            double radius = double.Parse(radiusInput);
            double area = Math.PI * radius * radius;
            double roundedValueOfArea = Math.Round(area, 2);
            Console.WriteLine($"The area of the circle with the given radius is:{roundedValueOfArea}");
        }
    }
}
