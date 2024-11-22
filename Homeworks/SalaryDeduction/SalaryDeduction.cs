Console.WriteLine("Enter the number of open tabs in the browser:");
int numberOfTabs = int.Parse(Console.ReadLine());

if (numberOfTabs < 1 || numberOfTabs > 10)
{
    Console.WriteLine("Invalid number of open tabs.");
}

Console.WriteLine("Enter salary:");
int salary = int.Parse(Console.ReadLine());

if (salary < 700 || salary > 1500)
{
    Console.WriteLine("Invalid salary.");
    return;
}


int facebookFine = 150;
int instagramFine = 100;
int redditFine = 50;

for (int i = 0; i < numberOfTabs; i++)
{
    Console.WriteLine("Enter the name of the website:");
    string website = Console.ReadLine().ToLower();

    if (website == "facebook")
    {
        salary -= facebookFine;
    }
    else if (website == "instagram")
    {
        salary -= instagramFine;
    }
    else if (website == "reddit")
    {
        salary -= redditFine;
    }

    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        return;
    }
}

Console.WriteLine($"Your remaining salary is: {salary} BGN.");