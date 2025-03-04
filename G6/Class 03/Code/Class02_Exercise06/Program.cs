//Create two variables and initialize them with a keyboard input
//Write code that can test which number is larger
//Write code that can test the numbers whether they are even or odd
//Output:
//Write in the console: The larger number from the two is #Number#
//After that write: And the number is even/odd

Console.WriteLine("Please enter the first number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.WriteLine("Please enter the second number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);

if(firstSuccess && secondSuccess)
{
    if(firstNumber % 2 == 0)
    {
        Console.WriteLine($"The first number {firstNumber} is an even number");
    }
    else
    {
        Console.WriteLine($"The first number {firstNumber} is an odd number");
    }

    if (secondNumber % 2 == 0)
    {
        Console.WriteLine($"The second number {secondNumber} is an even number");
    }
    else
    {
        Console.WriteLine($"The second number {secondNumber} is an odd number");
    }

    if (firstNumber > secondNumber)
    {
        Console.WriteLine("The first number is greater than the second number");
    }
    else if (firstNumber < secondNumber)
    {
        Console.WriteLine("The second number is greater than the first number");
    }
    else
    {
        Console.WriteLine("The numbers are equal");
    }
}
else
{
    Console.WriteLine("Invalid input! Please enter valid numbers!");
}