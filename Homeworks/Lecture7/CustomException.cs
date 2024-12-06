namespace Lecture7
{
    class CustomException
    {
        public void ValidateAge(int Age)
        {
            if (Age < 0 || Age > 150)
            {
                throw new InvalidAgeException("Invalid age");
            }
            else
            {
                Console.WriteLine("Age is valid");
            }

        }

        public static void TestExceptions(string[] args)
        {
            CustomException customException = new CustomException();

            try
            {
                customException.ValidateAge(10);
            }
            catch (InvalidAgeException ex)
            {

                Console.WriteLine(ex.Message); ;
            }

            try
            {
                customException.ValidateAge(0);
            }
            catch (InvalidAgeException ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            try
            {
                customException.ValidateAge(-1);
            }
            catch (InvalidAgeException ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            try
            {
                customException.ValidateAge(150);
            }
            catch (InvalidAgeException ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            try
            {
                customException.ValidateAge(151);
            }
            catch (InvalidAgeException ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }
        class InvalidAgeException : Exception
        {
            public InvalidAgeException(string text) : base(text) { }

        }
    }
}