Console.WriteLine("Enter value of x:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter value of y:");
int secondNumber = int.Parse(Console.ReadLine());

int quatitient, remainder;
Division(firstNumber, secondNumber, out quatitient, out remainder);

Console.WriteLine($"The quotient is:{quatitient} ");
Console.WriteLine($"The remainder is:{remainder} ");
void Division(int x, int y, out int quatitient, out int remainder)
{
    quatitient = x / y;
    remainder = x % y;
}