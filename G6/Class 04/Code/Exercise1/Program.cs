//Create 2 methods called Sum and Subtract
//Sum will accept two numbers as parameters and return the sum as a result
//Subtract will accept two numbers as parameters and return a subtract result
//Ask a person from the console to enter - or +
//Then ask the person to enter two numbers
//Call the corresponding method ( sum or subtract ) and return the result to the console

int Sum(int a, int b)
{
    return a+b;
}

int Substract(int a, int b)
{
    return a-b;
}

Console.WriteLine("Enter the first number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.WriteLine("Enter the second number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);

Console.WriteLine("Enter + or -");
string op = Console.ReadLine();

if (firstSuccess && secondSuccess)
{
    if(op == "+")
    {
        int sum = Sum(firstNumber, secondNumber);
        Console.WriteLine("The sum is: " + sum);
    }
    else if(op == "-") 
    {
      int result = Substract(firstNumber, secondNumber);
      Console.WriteLine("The result is: "+ result);
    }
    else
    {
        Console.WriteLine("Wrong operator!");
    }

}
else
{
    Console.WriteLine("Wrong input!");
}