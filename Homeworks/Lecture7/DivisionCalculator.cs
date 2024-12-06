namespace Lecture7
{
    class DivisionCalculator
    {
        public void DivideNumbers(int dividend, int divisor)
        {
            try
            {
                int result = dividend / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Devision by zero is not possible.");
            }
        }
    }
}
