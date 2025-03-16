


static void NumberStats(string number)
{
    if (!IsValidNumber(number))
    {
        Console.WriteLine("You entered invalid number! Please enter valid number:");
        return;
    }

    double.TryParse(number, out double numberParsed);

    if (IsPositive(numberParsed))
        Console.WriteLine("Positive");
    else
        Console.WriteLine("Negative");

    if (IsEven(numberParsed))
        Console.WriteLine("Even");
    else
        Console.WriteLine("Odd");

    if (IsInteger(number))
        Console.WriteLine("Integer");
    else
        Console.WriteLine("Decimal");
}


static bool IsValidNumber(string number)
{
    return double.TryParse(number, out double doubleResult) ||
        int.TryParse(number, out int intResult);
}
static bool IsPositive(double number)
{
    return number > 0;
}
static bool IsEven(double number)
{
    return number % 2 == 0;
}
static bool IsInteger(string number)
{
    return int.TryParse(number, out int result);
}


while (true)
{
    Console.Clear();
    Console.WriteLine("Please enter a number:");
    string userInput = Console.ReadLine();

    NumberStats(userInput);
    Console.WriteLine("Do you want to continute: Y / N?");
    string shouldContinue = Console.ReadLine();
    if (shouldContinue.ToLower() == "n")
        break;
}