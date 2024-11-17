namespace Homeworks.Lecture_2
{
    class Task1
    {
        public void ConvertAndAddTwoNumbers()
        {
            //Objective: Prompt the user to input two numbers as strings, convert them to integers, and display their sum.
            //Instructions: Use int.Parse() or TryParse() to convert the inputs to integers.

            Console.WriteLine("Enter number 1:");
            string numberOne = Console.ReadLine();

            Console.WriteLine("Enter number 2:");
            string numberTwo = Console.ReadLine();

            int.TryParse(numberOne, out int numberOneasInt);
            int.TryParse(numberTwo, out int numberTwoasInt);

            Console.WriteLine($"The sum of number 1 and number 2 is: {numberOneasInt + numberTwoasInt}");
        }
    }
}