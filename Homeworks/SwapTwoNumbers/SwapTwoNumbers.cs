int firstNumber, secondNumber;
Console.WriteLine("Enter value of x:");
while (!int.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.WriteLine("Invalid input");
}

Console.WriteLine("Enter value of y:");
while (!int.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.WriteLine("Invalid input.");
}
SwapNumbers(ref firstNumber, ref secondNumber);
Console.WriteLine($"The value of x is:{firstNumber} ");
Console.WriteLine($"The value of y is:{secondNumber} ");
void SwapNumbers(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}