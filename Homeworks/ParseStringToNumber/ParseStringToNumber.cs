Console.WriteLine("Enter the string:");
string input = Console.ReadLine();

isAbleToConvertStringToNumber(input, out int number);
void isAbleToConvertStringToNumber(string input, out int number)
{
    if (int.TryParse(input, out number))
    {
        Console.WriteLine(number);
    }
    else
    {
        number = 0;
        Console.WriteLine(number);
    }
}
