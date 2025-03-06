//Strings

string message = "We are learning about strings";
string academy = "Qinshift";

//concatenation
string firstMessage = "Welcome to " + academy;
Console.WriteLine(firstMessage);

//interpolation
string secondMessage = $"Welcome to {academy}";
Console.WriteLine(secondMessage);

int year = 2025;
string thirdMessage = $"Welcome to {academy} in {year} year";
Console.WriteLine(thirdMessage);

//formatting strings
string fourthMessage = string.Format("Welcome to {0} in {1} year!", academy, year);
Console.WriteLine(fourthMessage);

//escape
string firstString = "Check your c:\\drive";

string secondString = "We will have \"fair\" elections";
Console.WriteLine(secondString);

// \n means new line
string thirdString = "This is first line. \n This is second line";
Console.WriteLine(thirdString);