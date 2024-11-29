Console.WriteLine("Enter a number:");
int inputNumber = int.Parse(Console.ReadLine());

List<int> FibonacciSequence(int x)
{

    List<int> fibonacciList = new List<int>();

    if (x >= 1)
    {
        fibonacciList.Add(0);
    }
    if (x >= 2)
    {
        fibonacciList.Add(1);
    }

    for (int i = 2; i < x; i++)
    {
        int nextNumber = fibonacciList[i - 1] + fibonacciList[i - 2];
        fibonacciList.Add(nextNumber);
    }

    return fibonacciList;
}


Console.WriteLine($"The first {inputNumber} number from the Fibonacci sequence are: {string.Join(",", FibonacciSequence(inputNumber))}");