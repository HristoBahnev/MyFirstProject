Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(checkIsPrime(number) ? "true (prime)" : "false (not prime)");

bool checkIsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
            break;
        }
    }
    return true;
}