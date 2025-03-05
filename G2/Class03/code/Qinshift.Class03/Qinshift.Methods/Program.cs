//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");
//        Greet();

//        Console.ReadLine();
//    }
//    private static void Greet()
//    {
//        Console.WriteLine("Hello from the awesome students of G2");
//    }
//}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n================== METHODS ==================\n");
Console.ResetColor();

// 1) Method with no parameters & no return (*void*)
// => Method Declaration
void Greet()
{
    Console.WriteLine("Hello from the awesome students of G2");
}
// => Method Execution
Greet();
Greet();
Greet();


// 2) Method with parameters but no return (void)
GreetStudent("Bob");
//void greetStudent() // BAD NAMING !
//{

//}

void GreetStudent(string name)
{
    Console.WriteLine($"Hello {name}!");
}


// 3) Method with parameters and return
string GetFullName(string firstName, string lastName)
{
    return firstName + " " + lastName;
}

string bob = GetFullName("Bob", "Bobsky");
Console.WriteLine(bob);


// 4) Method with 3 parameters and no return value
void PrintPersonInfo(string firstName, string lastName, bool isStudent)
{
    if (isStudent)
    {
        Console.WriteLine($"{GetFullName(firstName, lastName)} is a programming student at Qinshift Academy.");
        return; // in *void* methods  we can use 'return' keyword to simply prevent further code execution
    }
    Console.WriteLine($"{GetFullName(firstName, lastName)} is NOT a programming student at Qinshift Academy.");
}

PrintPersonInfo("Bob", "Bobsky", false);
PrintPersonInfo("Johnny", "Bravo", true);