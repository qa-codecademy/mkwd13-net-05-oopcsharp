/*Comment in multiple
 lines*/

Console.WriteLine("Data types:");

//Whole numbers
int firstIntVariable = 5555; //declaration & initialization
Console.WriteLine("firstIntVariable: " +  firstIntVariable); //concatenation

short firstShortVariable = 6; //declaration & initialization
Console.WriteLine($"firstShortVariable: {firstShortVariable}. firstIntVariable: {firstIntVariable}"); //interpolation

//int firstIntVariable = 444; //Error - cannot declare a variable with the same name 


//reinitialization - we can change the value of the variable
firstIntVariable = 7;
Console.WriteLine("firstIntVariable: " + firstIntVariable);

//firstIntVariable = "G6"; - cannot change the data type of the variable

//Decimal numbers
float firstFloatVariable = 1.567f; //we need to use f or F to make the number of type float
Console.WriteLine($"firstFloatVariable: {firstFloatVariable}");

double firstDoubleVariable = 2.456;
Console.WriteLine($"firstDoubleVariable: {firstDoubleVariable}");

//char
char firstCharVariable = 'a'; //chars are always written in single quotes
Console.WriteLine("firstCharVariable: " +  firstCharVariable);
//firstCharVariable = 'aaaa' -> too many characters, char can only have one character
//firstCharVariable = "a" -> if we use double quotes that is a string


//string
string message = "Hello G6 from Qinshift Academy!"; //for strings we use double quotes
Console.WriteLine(message);

string singleCharacterString = "T"; //this is also a string because of the double quotes

//bools
bool firstBoolVariable = true;
bool secondBoolVariable = false;
Console.WriteLine($"firstBoolVariable: {firstBoolVariable}, secondBoolVariable: {secondBoolVariable}");

int number; //declaration
number = 5; //initialization
number = 10;
//number = "Hello"; ->ERROR
//a = 1; -> ERROR

//implicitly typed varaibles take the type of the first value that is given to the variable
var secondNumber = 5;
secondNumber = 5555;
//secondNumber = "G6"; -> We cannot change the type of the variable, it takes the type when it is first initialized

string secondVariable; //this is okay because we already told it that it will have the type string
//var secondString; //we need to initialize the variable so that it can take the type from the value


//DateTime
DateTime dateTime = DateTime.Now; //taked the current date and time
Console.WriteLine("At the moment: " + dateTime);

//Operators
int sum = 5 + 5;
Console.WriteLine("sum " + sum);

sum += 90;
Console.WriteLine("sum " + sum);

//Console.WriteLine(testVariable); //we cannot use the testVariable here
int testVariable;
//Console.WriteLine(testVariable); //we still cannot use it here, it does not have a value
testVariable = 5;
Console.WriteLine(testVariable); //we can use it now

sum++; // sum = sum + 1; sum +=1

int secondSum = sum; //we can use the value of another variable if it is from the same type
//string stringSum = sum; //we cannot do it if they have different data types




















































































































