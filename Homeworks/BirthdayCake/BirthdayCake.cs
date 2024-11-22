Console.WriteLine("Enter the width of the cake:");
int width = int.Parse(Console.ReadLine());

if (width < 1 || width > 1000)
{
    Console.WriteLine("Invalid width.");
    return;
}

Console.WriteLine("Enter the length of the cake:");
int length = int.Parse(Console.ReadLine());

if (length < 1 || length > 1000)
{
    Console.WriteLine("Invalid width.");
    return;
}

int totalPieces = width * length;

while (totalPieces > 0)
{
    Console.WriteLine("Enter the number of pieces:");
    string input = Console.ReadLine();

    if (input == "STOP".ToLower())
    {
        Console.WriteLine($"{totalPieces} pieces are left.");
        return;
    }

    int piecesTaken = int.Parse(input);
    totalPieces -= piecesTaken;
}

Console.WriteLine($"No more cake left! You need {-totalPieces} pieces more.");