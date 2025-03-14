using Qinshift.Exercise1.Models;

Console.WriteLine("Hello there!");
Console.WriteLine("Enter your firstname:");
string fName = Console.ReadLine();

Console.WriteLine("Enter your lastname:");
string lName = Console.ReadLine();

Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

Human human = new Human(fName, lName, age);
Console.WriteLine(human.GetPersonStats());
