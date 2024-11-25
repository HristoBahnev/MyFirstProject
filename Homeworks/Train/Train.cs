Console.WriteLine("Enter the passengers in each wagon:");
List<int> passengersPerWagon = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

Console.WriteLine("Enter the max capacity of passengers in each wagon:");
int maxPassengersPerWagon = int.Parse(Console.ReadLine());

while (true)
{
    string input = Console.ReadLine();

    if (input.ToLower() == "end")
    {
        break;
    }

    string[] parts = input.Split();
    if (parts[0].ToLower() == "add")
    {
        passengersPerWagon.Add(int.Parse(parts[1]));
    }
    else
    {
        int passengersToAdd = int.Parse(parts[0]);
        for (int i = 0; i < passengersPerWagon.Count; i++)
        {
            if (passengersPerWagon[i] + passengersToAdd <= maxPassengersPerWagon)
            {
                passengersPerWagon[i] += passengersToAdd;
                break;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", passengersPerWagon));
