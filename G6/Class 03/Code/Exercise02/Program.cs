//Get an input number from the console
//Print all even numbers starting from 2
//Get another input number from the console
//Print all odd numbers starting from 1

Console.Write("Enter a number:");
bool firstSuccess = int.TryParse(Console.ReadLine(), out int firstNumber);

if (firstSuccess)
{
    for(int i = 2; i<=firstNumber; i += 2) //every second number, starting from 2 is an even number (2,4,6,8...)
    {
        Console.WriteLine(i);
    }

    for (int i = 2; i <= firstNumber; i++) //second way, with the classic check for even numbers
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    Console.WriteLine("Wrong input");
}

Console.Write("Enter another number:");
bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);

if (secondSuccess)
{
    for(int i = 1; i<=secondNumber; i += 2) //every second number, starting from 1 is an odd number 1,3,5,7....
    {
        Console.WriteLine(i);
    }

    for(int i = 1;i <= secondNumber; i++) //second way 
    {
        if(i%2 != 0) //if the remaining is not 0, then it is an odd number
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    Console.WriteLine("Wrong input");
}
