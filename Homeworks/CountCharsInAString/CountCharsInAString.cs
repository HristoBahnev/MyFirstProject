using System.Linq;

Console.WriteLine("Enter a word:");
String input = Console.ReadLine();

Dictionary<char, int> charactersCounter = new Dictionary<char, int>();

foreach (char c in input)
{
    if (c != ' ')
    {
        if (charactersCounter.ContainsKey(c))
        {
            charactersCounter[c]++;
        }
        else
        {
            charactersCounter[c] = 1;
        }
    }
}

foreach (var c in charactersCounter)
{
    Console.WriteLine($"{c.Key} -> {c.Value}");
}