//In the existing Console Application create a new method called Substrings
//In that method enter the following string :
//"Hello from Qinshift Codecademy 2024"
//Ask the user to enter a number n.
//Print the first n characters from that string and print the length of the new string.
//Try to handle all the scenarios.

Console.WriteLine("Please enter a number:");
string input = Console.ReadLine();
bool success = int.TryParse(input, out int number);

if (success)
{
    Substrings(number);
}
else
{
    Console.WriteLine("Wrong input!");
}

void Substrings(int n)
{
    string text = "Hello from Qinshift Codeacademy 2024";
    if(n > text.Length)
    {
        n = text.Length;
        //Console.WriteLine($"Our text has {text.Length} chars and {n} chars cannot be accessed");
        //return;
    }

    string substring = text.Substring(0, n);
    Console.WriteLine(substring);
    Console.WriteLine(substring.Length);
}