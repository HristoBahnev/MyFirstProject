int firstNumber, secondNumber;
Console.WriteLine("Enter value of x:");
while (!int.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.WriteLine("Invalid input");
}

Console.WriteLine("Enter value of y:");
while (!int.TryParse(Console.ReadLine(), out secondNumber) )
{
    Console.WriteLine("Invalid input.");
}

int quatitient, remainder;
Division(firstNumber, secondNumber, out quatitient, out remainder);

Console.WriteLine($"The quotient is:{quatitient} ");
Console.WriteLine($"The remainder is:{remainder} ");
void Division(int x, int y, out int quatitient, out int remainder)
{
    quatitient = x / y;
    remainder = x % y;
}