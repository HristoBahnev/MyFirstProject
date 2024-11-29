Console.WriteLine("Enter an array to be sorted:");
int[] inputArray = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

Console.WriteLine(string.Join(",", sortAnArray(inputArray)));


int[] sortAnArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        for (int j = 0; j < inputArray.Length - i - 1; j++)
        {
            if (inputArray[j] > inputArray[j + 1])
            {
                int temp = inputArray[j];
                inputArray[j] = inputArray[j + 1];
                inputArray[j + 1] = temp;
            }
        }

    }
    return inputArray;
}