Console.WriteLine("Enter budget:");
int budget = int.Parse(Console.ReadLine());

if (budget < 1 || budget > 8000)
{
    Console.WriteLine("Invalid budget");
    return;
}

Console.WriteLine("Enter season:");
string season = Console.ReadLine().ToLower();

double price = 0;

switch (season)
{
    case "spring":
        price = 3000;
        break;
    case "summer":
        price = 4200;
        break;
    case "atumn":
        price = 4200;
        break;
    case "winter":
        price = 2600;
        break;
    default:
        Console.WriteLine("Invalid season");
        return;
}

Console.WriteLine("Enter number of fishermen:");
int fishermen = int.Parse(Console.ReadLine());

if (fishermen >= 4 && fishermen <= 6)
{
    price *= 0.90;
}
else if (fishermen >= 7 && fishermen <= 11)
{
    price *= 0.85;
}
else if (fishermen >= 12 && fishermen <= 18)
{
    price *= 0.75;
}
else
{
    Console.WriteLine("Invalid number of fishermen");
    return;
}

if (fishermen % 2 == 0 && season != "autumn")
{
    price *= 0.95;
}

if (budget >= price)
{
    Console.WriteLine("The budget is enough.");
}
else
{
    Console.WriteLine($"There is not enough money, brother.");
}