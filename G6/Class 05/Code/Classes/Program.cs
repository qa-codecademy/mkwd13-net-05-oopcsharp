using Classes;

//Program.cs is always the first class that gets called when executing a project
//That's why we create the objects from Person here

Person firstPerson = new Person(); //calls the empty constructor
firstPerson.FirstName = "Petko";
Console.WriteLine(firstPerson.FirstName);

//_ssn is private and can be accessed only in the class
//firstPerson._ssn => ERROR

Person secondPerson = new Person("Stefan", "Stefanovski");
Console.WriteLine(secondPerson.FirstName);
Console.WriteLine(secondPerson.LastName);
Console.WriteLine(secondPerson.Age); //0

Person thirdPerson = new Person("Nikola", "Nikolovski", 25, 111999);
Console.WriteLine(thirdPerson.FirstName);
Console.WriteLine(thirdPerson.LastName);
Console.WriteLine(thirdPerson.Age);

firstPerson.PrintDetails();
secondPerson.PrintDetails();
thirdPerson.PrintDetails();

Console.WriteLine(thirdPerson.GetSSN());
//thirdPerson._ssn; => ERROR
//thirdPerson._ssn = 123123; => ERROR
firstPerson.SetSSN(123123);
Console.WriteLine(firstPerson.GetSSN());