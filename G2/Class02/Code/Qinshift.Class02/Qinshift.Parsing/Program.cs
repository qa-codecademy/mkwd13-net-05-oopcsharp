

//string fullName = Console.ReadLine();
//Console.WriteLine(fullName);

Console.WriteLine("============ DATA CONVERSION ============");

#region Parse
//int userNumber = int.Parse(Console.ReadLine());
//double userDecimalInput = double.Parse(Console.ReadLine());
//bool input = bool.Parse(Console.ReadLine());



//Console.WriteLine(userNumber);
//Console.WriteLine(userDecimalInput);
//Console.WriteLine(input);

#endregion

#region Convert.To...()
//int userInput = Convert.ToInt32(Console.ReadLine());
//double userDecimal = Convert.ToDouble(Console.ReadLine());
//bool userBoolInput = Convert.ToBoolean(Console.ReadLine());



//Console.WriteLine(userInput);
//Console.WriteLine(userDecimal);
//Console.WriteLine(userBoolInput);
#endregion

#region TryParse()
bool userInput1 = int.TryParse(Console.ReadLine(), out int parsedNumber);
bool userDecimal1 = double.TryParse(Console.ReadLine(), out double parsedDoubleNum);
bool userBoolInput1 = bool.TryParse(Console.ReadLine(), out bool parsedBoolValue);



Console.WriteLine(userInput1);
Console.WriteLine(userDecimal1);
Console.WriteLine(userBoolInput1);
#endregion