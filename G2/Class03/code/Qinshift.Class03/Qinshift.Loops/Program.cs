Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("============= LOOPS =============");
Console.ResetColor();


Console.WriteLine("\n======= While =======\n");

// Example: Print numbers from 1 to 10 
int counter = 0;
while (counter < 10)
{
    counter++;
    //Console.WriteLine(counter);
}

// Example: Print odd numbers from 1 to 10 
counter = 0;
while (counter < 10)
{
    counter++;
    if (counter % 2 == 0)
    {
        continue;
    }
    //Console.WriteLine(counter);
}

// Example: Read something from console, stop when user enters X
//while (true)
//{
//    Console.Write("Enter something (type 'X' to stop)");
//    string input = Console.ReadLine();
//    if (input.ToUpper() == "X")
//    {
//        Console.WriteLine("Exiting...");
//        break;
//    }
//    Console.WriteLine(input);
//}


Console.WriteLine("\n======= Do While =======\n");

// Example: Get valid number input
bool isValid;
do
{
    Console.Write("Enter number: ");
    string input = Console.ReadLine();
    isValid = int.TryParse(input, out int parsedNumber);
    if (isValid)
    {
        Console.WriteLine($"The parsed number is {parsedNumber}");
    }
    else
    {
        Console.WriteLine("Invalid input! Try again!");
    }
} while (!isValid);


Console.WriteLine("\n======= For =======\n");

// Example: Print numbers from 1 to 100 
//for (int i = 1; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}

// Example: Print numbers from 100 to 1 
//for(int i = 100; i > 0; i--)
//{
//    Console.WriteLine(i);
//}

string[] students = new string[4] { "Ace", "Bace", "Cace", "Dace" };

// Example: Loop through an array
for(int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"{i + 1}. {students[i]}");
}


Console.WriteLine("\n======= Foreach =======\n");

foreach(string name in students)
{
    Console.WriteLine(name);
}