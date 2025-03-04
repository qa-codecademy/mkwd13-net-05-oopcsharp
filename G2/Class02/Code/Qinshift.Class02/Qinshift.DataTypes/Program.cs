Console.WriteLine("================ DATA TYPES AND VARIABLES =============");


#region Variables and data types
int testVariable;
int number = 5;
int studentCount = 19;

int veryBigNumber1 = -2147483648;

// Cannot declare int variable with value lower than -2147483648
// or bigger than 2147483647. C# will treat that as 'long' type

//int veryBigNumber2 = -21474836482;

long veryBigNumber2 = -2147483648223231231;
short buildingFloors = 10;




// This will throw an error because testVariable is not initialized
// If you don't need to initialize the variable at the moment, 
// you can add default value of zero.

//Console.WriteLine(testVariable);

Console.WriteLine(number);
Console.WriteLine(studentCount);
Console.WriteLine(veryBigNumber2);
Console.WriteLine(buildingFloors);


double price = 19.4;
decimal tax = 1.4M;
float weight = 70.4f;


char specialCharacter = '%';

string firstName = "Martin";
string lastName = "Panovski";

bool isThursday = true;
bool isRaining = false;

Console.WriteLine(price);
Console.WriteLine(tax);
Console.WriteLine(weight);
Console.WriteLine(specialCharacter);
Console.WriteLine(firstName);
Console.WriteLine(lastName);
Console.WriteLine(isThursday);
Console.WriteLine(isRaining);
#endregion



#region Operators
Console.WriteLine("================ OPERATORS =============");
int a = 10;
int b = 15;

double c = 10;
double d = 15;

int sum = a + b;
int difference = a - b;
int product = a * b;
// In order to divide two numbers, the result variable must be of type double
// if you expect reminder. Otherwise, it will be rounded to the nearest integer
double division = c / d;
int modulus = a % b;

Console.WriteLine(sum);
Console.WriteLine(difference);
Console.WriteLine(division);
Console.WriteLine(product);
Console.WriteLine(modulus);


bool isGreater = a > b;
Console.WriteLine(isGreater);


string academyName = "SEDC";
string courseName = "QA Automation";
string fullCourseName = academyName + " " + courseName;
Console.WriteLine(fullCourseName);


#endregion

#region Default values
Console.WriteLine("================ DEFAULT VALUES =============");

int someNumber = default;       // defult for int is 0
string someText = default;      // default for string is null
bool someBoolean = default;     // default for bool is false
double someDouble = default;    // default for double is 0

Console.WriteLine(someNumber);
Console.WriteLine(someText);
Console.WriteLine(someBoolean);
Console.WriteLine(someDouble);
#endregion


#region Exercises

// Exercise 1

Console.WriteLine("================ EXERCISE 1 =============");

double doubleVar1 = 10.5;
double doubleVar2 = 2.5;
double doubleDivision = doubleVar1 / doubleVar2;

int intVar1 = 10;
int intVar2 = 2;
int intDivision = intVar1 / intVar2;

Console.WriteLine("Double Division: " + doubleDivision);
Console.WriteLine("Integer Division: " + intDivision);
Console.ReadLine();


Console.WriteLine("================ EXERCISE 2 =============");

string greeting = "Hello";
string entity = "World";
string fullGreeting = greeting + " " + entity;

string numberStr1 = "9";
string numberStr2 = "3";
string concatenatedNumberStr = numberStr1 + numberStr2;

Console.WriteLine("Concatenated String: " + fullGreeting);
Console.WriteLine("Concatenated Number and String: " + concatenatedNumberStr);
Console.ReadLine();


Console.WriteLine("================ EXERCISE 3 =============");

int someNum = 9;
string text = " apples";
string concatenatedResult = number + text;

Console.WriteLine("Concatenated Result: " + concatenatedResult);
Console.ReadLine();

Console.WriteLine("================ EXERCISE 4 =============");

int totalCredits = 102; // Example value for total credits
int costPerSms = 5; // Example value for cost per SMS
int numberOfSms = totalCredits / costPerSms;

Console.WriteLine("Number of SMS messages you can send: " + numberOfSms);
#endregion