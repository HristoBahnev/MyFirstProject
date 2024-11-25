Console.WriteLine("Enter the hands of the first player:");
List<int> firstPlayerDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

Console.WriteLine("Enter the hands of the second player:");
List<int> secondPlayerDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


while (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count > 0)
{
    int firstPlayerHand = firstPlayerDeck[0];
    int secondPlayerHand = secondPlayerDeck[0];

    if (firstPlayerHand > secondPlayerHand)
    {
        firstPlayerDeck.Add(firstPlayerHand);
        firstPlayerDeck.Add(secondPlayerHand);
    }
    else if (secondPlayerHand > firstPlayerHand)
    {
        secondPlayerDeck.Add(secondPlayerHand);
        secondPlayerDeck.Add(firstPlayerHand);
    }
    firstPlayerDeck.RemoveAt(0);
    secondPlayerDeck.RemoveAt(0);
}
if (firstPlayerDeck.Count > 0)
{
    Console.WriteLine($"First player wins! Sum:{firstPlayerDeck.Sum()}");
}
else if (secondPlayerDeck.Count > 0)
{
    Console.WriteLine($"Second player wins! Sum:{secondPlayerDeck.Sum()}");
}
