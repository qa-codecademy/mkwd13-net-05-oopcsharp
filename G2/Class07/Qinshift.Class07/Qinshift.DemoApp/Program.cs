using Qinshift.Library.Enums;
using Qinshift.Library.Services;

#region Enums and how to use them

Console.WriteLine(Days.Monday);

IsLecutreDay(Days.Monday);
IsLecutreDay(Days.Tuesday);


static void IsLecutreDay(Days day)
{
    if (day == Days.Tuesday || day == Days.Thursday)
    {
        Console.WriteLine("You have lectures today!");
    }
    else
    {
        Console.WriteLine("You have to study hard today!");
    }
}
#endregion



#region Converting enums

Console.WriteLine("==================== Converting enums =====================");
int num = 2;
Days day = (Days)num;
Console.WriteLine(day);

Console.WriteLine("You give me a number I'll give you a month name:");
int userInput = int.Parse(Console.ReadLine());

// Get an enum value from a number (int)
//Months monthName = (Months)userInput;
//Console.WriteLine(monthName);

// Do the same (previous two lines) just by calling service method
MonthService monthService = new MonthService();
Console.WriteLine(monthService.GetMonthOutOfNumber(userInput));



// Get a number value from an enum
Months january = Months.January;
int firstMonth = (int)january;


// Get a string value from an enum
string july = Months.July.ToString();
Console.WriteLine($"July month: {july}");


#endregion