
Console.WriteLine("Please enter numebr:");
bool userInput1 = int.TryParse(Console.ReadLine(), out int parsedNumber);

Console.WriteLine("Please enter decimal number:");
bool userDecimal1 = double.TryParse(Console.ReadLine(), out double parsedDoubleNum);

Console.WriteLine("Please enter boolean value: true/false");
bool userBoolInput1 = bool.TryParse(Console.ReadLine(), out bool parsedBoolValue);

Console.WriteLine(userInput1);
Console.WriteLine(userDecimal1);
Console.WriteLine(userBoolInput1);


#region if/else

if (userInput1)
{
    Console.WriteLine("The user entered " + parsedNumber);
}
else 
{
    Console.WriteLine("Wrong input! Please try again!");
}


if (userBoolInput1)
{
    if (parsedBoolValue)
    {
        Console.WriteLine("Yeey! You got a true as a result!");
    }
    else
    {
        Console.WriteLine("Woop! You got false as a result!");
    }
}
else if(!userBoolInput1)
{
    Console.WriteLine("Wrong input! Please try again!");
}
else
{
    Console.WriteLine("The check is over!");
}
#endregion

#region Switch statement
//string day = "Wednesday";
Console.WriteLine("Please enter a day of the week, and I will tell you if you have lecture!");
string dayOfTheWeek = Console.ReadLine().ToLower();

switch (dayOfTheWeek)
{
    case "monday":
        Console.WriteLine("I don't have any lectures today!");
        break;
    case "tuesday":
        Console.WriteLine("Today I have lecture!");
        break;
    case "wednesday":
        Console.WriteLine("I don't have any lectures today!");
        break;
    case "thursday":
        Console.WriteLine("Today I have lecture!");
        break;
    case "friday":
        Console.WriteLine("I don't have any lectures today!");
        break;
    case "saturday":
    case "sunday":
        Console.WriteLine("Yeey! Weekend!");
        break;
    default:
        Console.WriteLine("No such day of the week!");
        break;
}



#endregion