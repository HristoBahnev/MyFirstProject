using System.Linq;

Dictionary<string, long> resources = new Dictionary<string, long>();

while (true)
{

    Console.WriteLine("Enter a resource:");
    String resource = Console.ReadLine().ToLower();

    if (resource == "stop".ToLower())
    {
        break;
    }

    Console.WriteLine("Enter a quantity:");
    long quantity = long.Parse(Console.ReadLine());

    if (quantity < 1 || quantity > 2000000000)
    {
        Console.WriteLine("Invalid quantity.");
        return;
    }

    if (resources.ContainsKey(resource))
    {
        resources[resource] += quantity;
    }

    else
    {
        resources.Add(resource, quantity);
    }
}

foreach (var r in resources)
{
    Console.WriteLine($"{r.Key} -> {r.Value}");
}