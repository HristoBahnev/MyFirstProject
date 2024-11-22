Console.WriteLine("Enter n:");
int n = int.Parse(Console.ReadLine());

if (n < 1 || n > 9)
{
    Console.WriteLine("'n' should be between 1 and 9.");
    return;
}

Console.WriteLine("Enter l:");
int l = int.Parse(Console.ReadLine());

if (l < 1 || l > 9)
{
    Console.WriteLine("'l' should be between 1 and 9.");
}

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        for (char k = 'a'; k <= 'a' + l - 1; k++)
        {
            for (char m = 'a'; m <= 'a' + l - 1; m++)
            {
                for (int o = Math.Max(i, j); o <= n; o++)
                {
                    if (o > i && o > j)
                    {
                        Console.WriteLine($"{i}{j}{k}{m}{o}");
                    }
                }
            }
        }
    }
}