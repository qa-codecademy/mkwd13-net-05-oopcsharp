Console.WriteLine("Type.Parse(value)");

string numberString = "20";

//int.parse will fail on any input besides a valid int string (any text string, null...)
int parsedIntString = int.Parse(numberString);
Console.WriteLine(parsedIntString.GetType());

double parsedDouble = double.Parse("92.3");
Console.WriteLine(parsedDouble.GetType());

string wrongString = "G6";
//int wrongStringParse = int.Parse(wrongString); -> throws an error
//int parseNullNumber = int.Parse(null); -> throws an error

Console.WriteLine("Convert.ToType(value)");

//short number = Convert.ToInt16(numberString);
int number = Convert.ToInt32(numberString);
Console.WriteLine(number.GetType());

//int wrongStringConvert = Convert.ToInt32(wrongString); ->throws an error, cannot convert a string
int nullConvert = Convert.ToInt32(null); //the result will be 0 instead of an error
Console.WriteLine(nullConvert);
Console.WriteLine(nullConvert.GetType());

Console.WriteLine("Type.TryParse(value)");

int parsedValue; //we need to declare a variable where we will store the parsed value
//in success we will store if the parsing was successful or not
//in parsedValue we will have the result from the parse
bool success =  int.TryParse(numberString, out parsedValue);
Console.WriteLine("success: "+success);
Console.WriteLine("parsedValue: " + parsedValue);

bool secondSuccess = int.TryParse("G6", out int parsedStringValue);
Console.WriteLine("secondSuccess: " + secondSuccess); //false
Console.WriteLine("parsedStringValue: " + parsedStringValue); //0

Console.WriteLine("Enter your group number:");
string input = Console.ReadLine();

bool inputSuccess = int.TryParse(input, out int parsedGroupNumber);

if (inputSuccess)
{
    Console.WriteLine("Hello from G" + parsedGroupNumber);
}
else
{
    Console.WriteLine("Wrong input! You didn't enter a number!");
}

//===Switch====
int day = 3;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Work day,but it isn't Monday");
        break;
    case 6:
    case 7:
        Console.WriteLine("It's the weekend!");
        break;
    default:
        Console.WriteLine("Invalid value! Enter a number between 1 and 7");
        break;
}