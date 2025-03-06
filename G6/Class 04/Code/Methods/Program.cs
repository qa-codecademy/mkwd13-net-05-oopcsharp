//Methods

//method with no params and no return values
//void represents that the method does not return anything
void PrintMessage()
{
    Console.WriteLine("Hello from our first method");
}

PrintMessage();

//method with string param and no return values
void Greeting(string name)
{
    Console.WriteLine($"Hello: {name}");
}
Greeting("G6");
//Greeting(10); //error greeting expects a string
//Greeting(); //error

void PrintInfo(string name, int age)
{
    Console.WriteLine($"{name} is {age}");
}

PrintInfo("Tijana", 25);
//PrintInfo(25, "Tijana"); //the string must be the first param and the int must be the second param

//Return values

string GetMessage()
{
    return "Hello from G6!";
}

string message = GetMessage();
Console.WriteLine(message);
Console.WriteLine(GetMessage());

string CheckIfItIsTheWeekend(bool isWeekend)
{
    if (isWeekend)
    {
        return "Yay! It is the weekend!";
    }
    else
    {
        return "It is a work day :(";
    }
}

string weekendMessage = CheckIfItIsTheWeekend(false);
Console.WriteLine(weekendMessage);
Console.WriteLine(CheckIfItIsTheWeekend(true));