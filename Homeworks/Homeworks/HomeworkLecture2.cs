using Homeworks.Lecture_2;

namespace Homeworks
{
    class HomeworkLecture2
    {
        public static void Main()
        {
            Task1 taskOne = new Task1();
            Task2 taskTwo = new Task2();
            Task3 taskThree = new Task3();
            Task4 taskFour = new Task4();
            Task5 taskFive = new Task5();

            taskOne.ConvertAndAddTwoNumbers();
            taskTwo.FormatAFullName();
            taskThree.ExtractAndModifySubstring();
            taskFour.CalculateTheAreaOfACircle();
            taskFive.ValidateAgeInput();
        }
    }
}