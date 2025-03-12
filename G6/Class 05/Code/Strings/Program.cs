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

//we can use @ to escape special characters in the whole string

string driveMessage = @"Check your c:\drive and D:\drive"; //"Check your C:\\drive and your D:\\drive"
Console.WriteLine(driveMessage);

string quotesString = @"We will have ""fair"" elections";

string percentString = string.Format("{0:P} participated in the elections", 0.57);
Console.WriteLine(percentString);

string phoneNumber = string.Format("{0:+389##-###-###}", 70123456); //+38970-123-456
Console.WriteLine(phoneNumber);

//String methods

string ourString = "    We are learning C# and it is FUN and EASY. Okay maybe just FUN.           ";
Console.WriteLine(ourString);

string lowerCaseString = ourString.ToLower(); //all characters to lower case
string upperCaseString = ourString.ToUpper(); //all characters to upper case
Console.WriteLine(lowerCaseString);
Console.WriteLine(upperCaseString);

//Length
Console.WriteLine("The length of our string is: " + ourString.Length);

//Split
string[] splittedString = ourString.Split('.');
Console.WriteLine(splittedString.Length); //3
Console.WriteLine(splittedString[0]);
Console.WriteLine(splittedString[1]);
Console.WriteLine(splittedString[2]);

//Replace
string stringWithDots = "Hello. from. G6";
string replacedStringWithoutDots = stringWithDots.Replace(".", "");
string replacedStringWithQuestionmarks = stringWithDots.Replace(".", "?");
Console.WriteLine(stringWithDots);
Console.WriteLine(replacedStringWithoutDots);
Console.WriteLine(replacedStringWithQuestionmarks);

//StartsWith
string test = "Test";

//returns a bool whether the string starts with the given string or not
bool startsWithTe = test.StartsWith("Te"); //we can send as many characters as we need ex. T or Te or Tes...
Console.WriteLine(startsWithTe); //true
bool strartsWithte = test.StartsWith("te");
Console.WriteLine(strartsWithte);//false

//IndexOf
int indexOfFun = ourString.IndexOf("FUN"); //returns the first occurence of FUN
int indexOfJs = ourString.IndexOf("JS"); //-1 - it did not find it
Console.WriteLine(indexOfFun);
Console.WriteLine(indexOfJs);

//Contains
//returns a bool 
bool containsFUN = ourString.Contains("FUN"); //true
bool containsJS = ourString.Contains("JS"); //false
Console.WriteLine(containsFUN);
Console.WriteLine(containsJS);

//Trim
string trimmedString = ourString.Trim();
Console.WriteLine(trimmedString);

//Substring
string substring = ourString.Substring(5, 16); //take the substring starting from index 5 and the next 16 characters
Console.WriteLine(substring);

//ToCharArray

char[] chars = ourString.ToCharArray(); 

foreach(char c in chars)
{
    Console.WriteLine(c);
}

string[] words = ourString.Split(" ");
foreach (string word in words)
{
    Console.WriteLine(word);
}