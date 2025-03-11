using Qinshift.Exercise2.Models;


string continueExecute = string.Empty;
while (continueExecute.ToLower() != "n")
{
    Console.WriteLine("Hello there!");
    Console.WriteLine("Enter your dog's name:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter your dog's race:");
    string race = Console.ReadLine();

    Console.WriteLine("Enter your dog's color:");
    string color = Console.ReadLine();

    Dog dog = new Dog(name, race, color);

    Console.WriteLine($"What do you want {dog.Name} to do: \n1.Eat \n2.Play \n3.Chase its tail. Select 1, 2 or 3");
    int userInput = int.Parse(Console.ReadLine());
    switch (userInput)
    {
        case 1:
            Console.WriteLine(dog.Eat());
            break;
        case 2:
            Console.WriteLine(dog.Play());
            break;
        case 3:
            Console.WriteLine(dog.ChaseTail());
            break;
        default:
            Console.WriteLine("Invalid input. Try again!");
            break;
    }

    Console.WriteLine("Do you want to continue? Y / N");
    continueExecute = Console.ReadLine();
    Console.Clear();
}


int[] numbers = new int[5];

