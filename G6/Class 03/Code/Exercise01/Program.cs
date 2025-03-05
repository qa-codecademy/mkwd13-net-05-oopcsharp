//Get an input number from the console
//Print all numbers from 1 up to that number
//Get another input number from the console
//Print all numbers starting from that number up to 1

Console.WriteLine("Please enter a number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

if (firstSuccess)
{
    for(int i=1; i<= firstNumber; i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Wrong input");
}

Console.WriteLine("Please enter another number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);

if (secondSuccess)
{
    for(int i = secondNumber; i>=1; i--) //i-- -> i = i-1 -> i -=1
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Wrong input");
}