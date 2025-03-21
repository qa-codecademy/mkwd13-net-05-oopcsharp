using Qinshift.Inheritance.Models;
using Qinshift.Library.Services;

Animal animal = new Animal();


Dog blacky = new Dog("Blacky", "dog", "black", "labrador");
blacky.Speak();

Cat mica = new Cat("Mica", "cat", "white", true);
mica.Speak();


Console.WriteLine("Enter number and I'll give you month name:");
MonthService monthService = new MonthService();
int userInput = int.Parse(Console.ReadLine());
Console.WriteLine(monthService.GetMonthOutOfNumber(userInput));