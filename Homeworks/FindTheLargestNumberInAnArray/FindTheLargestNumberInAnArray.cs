Console.WriteLine("Enter an array of integers, separated by comma:");
List<int> inputArray = Console.ReadLine().Split(",").Select(int.Parse).ToList();

Console.WriteLine($"The largest number in the array is: {GetLargestNumber(inputArray)}");

int GetLargestNumber(List<int> inputArray)
{

    int largestNumber = inputArray[0];
    foreach (int i in inputArray)
    {
        if (i > largestNumber)
        {
            largestNumber = i;
        }
    }
    return largestNumber;
}