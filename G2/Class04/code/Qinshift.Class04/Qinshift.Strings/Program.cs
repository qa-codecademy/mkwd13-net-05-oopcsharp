Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n================== STRINGS ==================\n");
Console.ResetColor();


#region String Concatenation

Console.WriteLine("\n\n============== String Concatenation ==============\n");

// Normal strings
string firstName = "Bob";
string lastName = "Bobsky";

// String Concatenation

// 1) using '+' operator
string hello1 = "Hello " + firstName + " " + lastName;
Console.WriteLine(hello1);
// 2) *using String Interpolation*
string hello2 = $"Hello {firstName} {lastName}";
Console.WriteLine(hello2);
// 3) using string.Format
string hello3 = string.Format("Hello {0} {1}", lastName, firstName);
Console.WriteLine(hello3);
// 4) using String.Concat
string hello4 = string.Concat("Hello ", firstName, " ", lastName);
Console.WriteLine(hello4);
// 5) using StringBuilder (only for info, will be explained in detail further on..)

#endregion


#region String Formatting

Console.WriteLine("\n\n============== String Formatting ==============\n");

// *Currency formatting*
//string currency = string.Format("Price {0:C}", 123.23);
string currency = string.Format("Price {0:C1}", 123.23);
Console.WriteLine(currency);

// *Percent formatting*
string percent = string.Format("Percent {0:P}", 0.5);
Console.WriteLine(percent);
Console.WriteLine(string.Format("Percent {0:P0}", 0.5));

// *Custom formatting*
string customPhoneNumberFormat = string.Format("Phone number: {0:0##-###-###}", 078223305);
Console.WriteLine(customPhoneNumberFormat);

int number = 1234567;
string customNumberFormat = string.Format("Number format {0:#,##0}", number);
Console.WriteLine(customNumberFormat);

// Alignment formatting
string customAlignment = string.Format("| {0,10} | {1,20} |", "Id", "Order");
Console.WriteLine(customAlignment);

#endregion


#region Escaping Reserved Characters
Console.WriteLine("\n\n============== Reserved Characters ==============\n");
// Reserved Characters in C#: \, \n, \t, \uXXXX, ", \a, etc...

//string escape1 = "Check your c:\ drive"; // error
//string escape2 = "We will have "fair" elections"; // error
//string escape3 = "The \n sign means: new line";
//Console.WriteLine(escape3);

// 1) Escaping with "\" (backslash) 
string escape1 = "Check your c:\\ drive"; 
string escape2 = "We will have \"fair\" elections"; 
string escape3 = "The \\n sign means: new line";

// 2) Escaping a whole string with @
escape1 = @"Check your c:\ drive";
escape2 = @"We will have ""fair"" elections";
escape3 = @"The \n sign means: new line";
Console.WriteLine(escape1);
Console.WriteLine(escape2);
Console.WriteLine(escape3);

#endregion


#region Using ToString()
Console.WriteLine("\n\n============== ToString() ==============\n");

int someNumber = 123456789;
bool isTrue = false;

// => Convert other datatypes to string
string someNumberString = someNumber.ToString();
string isTrueString = isTrue.ToString();
Console.WriteLine(someNumberString);
Console.WriteLine(isTrueString);

// => Using ToString for formatting 
string formatedString = someNumber.ToString("#,##0");
Console.WriteLine(formatedString);

#endregion


#region String Methods
Console.WriteLine("\n\n============== String Methods ==============\n");

string ourString = "   We are learning C#. It is FUN and EASY. Okay maybe just FUN.    ";
Console.WriteLine(ourString);

// 1) *ToUpper* & *ToLower*
// => Makes our string Upper/Lower Case
Console.WriteLine(ourString.ToUpper());
Console.WriteLine(ourString.ToLower());

// 2) Length (property)
// => Prints the length of our string
Console.WriteLine(ourString.Length);

// 3) *Split*
// => Splits the string and makes an array of strings (splits on specified character/delimeter )

string[] splittedString = ourString.Split('.');
Console.WriteLine("SPLITTED");
Console.WriteLine(splittedString[0]);
Console.WriteLine(splittedString[1]);
Console.WriteLine(splittedString[2]);
Console.WriteLine(splittedString[3]);

// 4) *Join*
// => Concatenates the members of a collection (array), using the specified separator between each member
string joinedString = string.Join(".(PERIOD)", splittedString);
Console.WriteLine(joinedString);

// 5) Trim
// => It trims the white spaces at the front and back of the string
string trimmedString = ourString.Trim();
Console.WriteLine(trimmedString);

// 6) StartsWith & EndsWith
// => Checks if a string starts with some string given and returns true or false
bool startsWith = trimmedString.StartsWith("We");
Console.WriteLine(startsWith); // true

// 7) *Contains*
// => Checks if a string contains some character or substring
bool containsString = trimmedString.Contains("learning");
Console.WriteLine(containsString);

// 8) *string.IsNullOrEmpty* & *string.IsNullOrWhitespace*
// => checks if a string is 'null' or empty ("") | or consists of whitespace ("   ")
// => used for string validations

Console.WriteLine("==== NULL OR EMPTY ====");
Console.WriteLine(string.IsNullOrEmpty("")); // true
Console.WriteLine(string.IsNullOrEmpty(null)); // true
Console.WriteLine(string.IsNullOrEmpty("132fds")); // false

Console.WriteLine(string.IsNullOrEmpty("   ")); // false
Console.WriteLine(string.IsNullOrWhiteSpace("   ")); // true
Console.WriteLine(string.IsNullOrWhiteSpace("   d")); // false

// 9) *Substring*
string substring = ourString.Substring(5, 16);
Console.WriteLine(substring);

// 10) IndexOf 
// => Checks if a string exists and if so returns an index, if not -1
int indexOfString = ourString.IndexOf("FUN");
int nonExistingString = ourString.IndexOf("Nope");
Console.WriteLine(indexOfString);
Console.WriteLine(nonExistingString);

// 11) ToCharArray
// => Creates an array of characters with every character from our string
char[] chars = ourString.ToCharArray();
Console.WriteLine(chars.Length);
Console.WriteLine(chars[6]);
// => Two ways to turn char[] back to string
Console.WriteLine(string.Join("", chars));
Console.WriteLine(new string(chars));

#endregion


Console.ReadLine();