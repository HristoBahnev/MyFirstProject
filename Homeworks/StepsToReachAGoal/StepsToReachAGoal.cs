int totalSteps = 0;

while (true)
{
    Console.WriteLine("Enter number of Steps: ");
    string input = Console.ReadLine();

    if (input.ToLower() == "going home")
    {
        Console.WriteLine("Enter the steps you  took while going home");
        int stepsToHome = int.Parse(Console.ReadLine());

        totalSteps += stepsToHome;
        break;
    }
    else
    {
        int steps;
        if (int.TryParse(input, out steps))
        {
            totalSteps += steps;
            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number of steps or 'Going home'.");
        }
    }
}

if (totalSteps >= 10000)
{
    Console.WriteLine("Goal reached! Good job!");
}
else
{
    int stepsNeeded = 10000 - totalSteps;
    Console.WriteLine($"{stepsNeeded} more steps to reach goal.");
}