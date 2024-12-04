
Console.WriteLine("Enter a string to reverse:");
string stringInput = Console.ReadLine();

string ReverseString(string stringInput)
{
    List<char> reversedList = new List<char>();

    foreach (char c in stringInput)
    {
        reversedList.Insert(0, c);
    }

    return string.Join("", reversedList);
}


Console.WriteLine($"Reversed string: {ReverseString(stringInput)}");