using System.ComponentModel.Design;

namespace Homeworks.Lecture_2
{
    class Task5
    {
        public void ValidateAgeInput()
        {
            //Objective: Ask the user to enter their age.Use TryParse() to check if the input is a valid integer, and display a message based on whether the age is valid or not.
            //Instructions: If TryParse returns false, display "Invalid age entered."


            Console.WriteLine("Enter your age:");
            string ageInput = Console.ReadLine();

            bool isValidAge = int.TryParse(ageInput, out int validAge);

            if (!isValidAge)
            {
                Console.WriteLine("Invalid integer entered.");
            }
            else if (validAge < 0)
            {
                Console.WriteLine("Invalid age entered.");
            }
            else
            {
                Console.WriteLine("Valid age entered.");
            }
        }
    }
}