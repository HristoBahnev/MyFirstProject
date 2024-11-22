double premierePrice = 12.00;
double normalPrice = 7.50;
double discountPrice = 5.00;
double totalRevenue = 0.0;

Console.WriteLine("Enter the type of screening:");
string screeningType = Console.ReadLine().ToLower();

Console.WriteLine("Enter the number of rows:");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns:");
int columns = int.Parse(Console.ReadLine());

int totalSeats = rows * columns;

switch (screeningType)
{
    case "premiere":
        totalRevenue = totalSeats * premierePrice;
        break;
    case "normal":
        totalRevenue = totalSeats * normalPrice;
        break;
    case "discount":
        totalRevenue = totalSeats * discountPrice;
        break;
    default:
        Console.WriteLine("Invalid screening type");
        return;
}

Console.WriteLine($"Total revenue: {totalRevenue:F2} BGN");