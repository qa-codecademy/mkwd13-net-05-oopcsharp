﻿Console.WriteLine("Enter your name");
string input = Console.ReadLine();
Console.WriteLine("Hello " +  input);

Console.WriteLine("Enter a number:");
var numberInput  = Console.ReadLine(); //this will also be a string
Console.WriteLine("numberInput "+ numberInput);

Console.WriteLine(numberInput.GetType()); //get the data type of the variable