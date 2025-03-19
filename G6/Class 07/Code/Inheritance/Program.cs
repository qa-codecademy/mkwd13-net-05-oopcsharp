using Inheritance.Models;

Animal animal = new Animal();
animal.Name = "Test animal";
animal.Type = "Test type";
//animal.Age => ERROR => protected property (Program.cs is not derived from Animal class)
//animal._Id => Error => private property

animal.PrintInfo();

//animal.PrintAge(); => ERROR => does not exist in Animal, only in Cat class

Cat cat = new Cat();
cat.Name = "Lucy";
cat.Type = "Cat";
cat.IsLazy = true;
cat.PrintAge(); //call the impl from the Cat class

cat.PrintInfo();

Dog dog = new Dog("Rex", "Brown");
dog.PrintInfo(); //it will call the printInfo method from the animal class (we haven't overriden that method in the dog class)

Dog newDog = new Dog();
