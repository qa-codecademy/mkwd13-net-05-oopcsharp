//Declare two double variables
//Initialize them and divide them in a new variable
//Declare two integer variables
//Initialize them and divide them in a new variable
//Print the results in the console and compare

double firstDouble;
double secondDouble;
firstDouble = 5; //we can store this in a double, because it is the same as 5.0
secondDouble = 1.3;
double doubleResult = firstDouble / secondDouble;

Console.WriteLine("doubleResult: " +doubleResult);

int firstInt, secondInt;
firstInt = 9;
secondInt = 4;
int intResult = firstInt / secondInt;
Console.WriteLine("intResult: " + intResult);

//when we divide two whole numbers the result will always be a whole number (it will take the whole part of the result)
double doubleIntResult = firstInt / secondInt;
Console.WriteLine("doubleIntResult: " + doubleIntResult);

//when we divide a whole number with a decimal number the result will be a decimal number
double differentTypesResult = firstInt / secondDouble;
Console.WriteLine("differentTypesResult: " + differentTypesResult);

//Extra - cast
double doubleIntCastResult = (double)firstInt / secondInt;
Console.WriteLine("doubleIntCastResult: " + doubleIntCastResult);