//The user needs to create the dog object by 
//inputs and then given an option to choose one of the actions mentioned above.

using Exercise02;
//Dog dog1 = new Dog();
Console.WriteLine("Enter the dog's name:");
string name = Console.ReadLine();
//dog1.Name = Console.ReadLine();
Console.WriteLine("Enter the dog's race:");
string race = Console.ReadLine();
Console.WriteLine("Enter the dog's color:");
string color = Console.ReadLine();

Dog dog = new Dog(name, race, color);

Console.WriteLine("What do you want the dog to do: \n 1.Feed the dog \n 2.Play \n 3.Chase its tail");

void DogOptions(Dog dog, int option)
{
    switch (option)
    {
        case 1: Console.WriteLine(dog.Eat());
            break;
        case 2: Console.WriteLine(dog.Play());
            break;
        case 3: Console.WriteLine(dog.ChaseTail());
            break;
        default: Console.WriteLine("No option like that, sorry :(");
            break;
    }
}

int result; //we need to declare it outside of the while block, so that we can use it
while (!int.TryParse(Console.ReadLine(), out result)) //we initialize the result in the while loop condition
{
    Console.WriteLine("You have entered a wrong option");
    Console.WriteLine("What do you want the dog to do: \n 1.Feed the dog \n 2.Play \n 3.Chase its tail");
}

DogOptions(dog, result);
