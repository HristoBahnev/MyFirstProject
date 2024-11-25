Console.WriteLine("Enter the array:");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

int winningCounter = 1;
int currentCounter = 1;
int number = numbers[0];

for (int i = 0; i < numbers.Length - 1; i++)
{
    if (numbers[i] == numbers[i + 1])
    {
        currentCounter++;
        if (currentCounter > winningCounter)
        {
            winningCounter = currentCounter;
            number = numbers[i];
        }
    }
    else
    {
        currentCounter = 1;
    }
}

for (int i = 0; i < winningCounter; i++)
{
    Console.WriteLine(string.Join(" ", number));
}
