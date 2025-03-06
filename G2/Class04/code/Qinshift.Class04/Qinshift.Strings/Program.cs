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



#endregion

Console.ReadLine();