Console.WriteLine("Enter value of x:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter value of y:");
int secondNumber = int.Parse(Console.ReadLine());

SwapNumbers(ref firstNumber, ref secondNumber);
Console.WriteLine($"The value of x is:{firstNumber} ");
Console.WriteLine($"The value of y is:{secondNumber} ");
void SwapNumbers(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}