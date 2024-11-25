Console.WriteLine("Enter the first array: ");
string[] itemsFromFirstArray = Console.ReadLine().Split(" ");

Console.WriteLine("Enter the second array: ");
string[] itemsFromSecondArray = Console.ReadLine().Split(" ");

foreach (string item in itemsFromSecondArray)
{
    foreach (string item2 in itemsFromFirstArray)
    {
        if (item2.Equals(item))
        {
            Console.WriteLine(string.Join(" ", item));
        }
    }
}