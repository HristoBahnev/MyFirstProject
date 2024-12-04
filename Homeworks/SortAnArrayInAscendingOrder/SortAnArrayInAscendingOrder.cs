Console.WriteLine("Enter an array to be sorted:");
int[] inputArray = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

Console.WriteLine(string.Join(",", sortAnArray(inputArray)));


int[] sortAnArray(int[] inputArray)
{
    for (int iteration = 0; iteration < inputArray.Length - 1; iteration++)
    {
        for (int currentIndex = 0; currentIndex < inputArray.Length - iteration - 1; currentIndex++)
        {
            if (inputArray[currentIndex] > inputArray[currentIndex + 1])
            {
                int temp = inputArray[currentIndex];
                inputArray[currentIndex] = inputArray[currentIndex + 1];
                inputArray[currentIndex + 1] = temp;
            }
        }

    }
    return inputArray;
}