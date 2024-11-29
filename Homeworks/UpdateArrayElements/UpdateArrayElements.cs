Console.WriteLine("Enter an array:");
int[] numbers = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

Console.WriteLine("Enter factor:");
int factor = int.Parse(Console.ReadLine());

MultiplyArrayElements(ref numbers, factor);
Console.WriteLine("Array After Multiplication: " + string.Join(", ", numbers));

void MultiplyArrayElements(ref int[] array, int factor)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= factor;
    }
}