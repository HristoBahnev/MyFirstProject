Console.WriteLine("Enter a number: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine(checkIsPrime(number) ? "true (prime)" : "false (not prime)");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}

bool checkIsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }
    for (int divisor = 2; divisor < number; divisor++)
    {
        if (number % divisor == 0)
        {
            return false;
        }
    }
    return true;
}