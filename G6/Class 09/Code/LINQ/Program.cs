using LINQ;

List<Dog> dogs = new List<Dog>()
{
    new Dog("Sparky", 1),
    new Dog("Butch", 2),
    new Dog("Hera", 3),
    new Dog("Luna", 1),
    new Dog("Lucy", 2),
    new Dog("Buck", 4),
};

//Find all dogs whose name has more than 4 characters
//this does not change the original list
List<Dog> dogsWithNameLongerThan4 = dogs.Where(x => x.Name.Length > 4).ToList();

Console.WriteLine("===========ORIGINAL LIST==========");
foreach(Dog dog in dogs)
{
    Console.WriteLine(dog.Name);
}

Console.WriteLine("===========Longer than 4==========");
foreach(Dog dog in dogsWithNameLongerThan4)
{
    Console.WriteLine(dog.Name);
}

//all dogs whose name starts with L
List<Dog> dogsStaringWithL = dogs.Where(d => d.Name.StartsWith("L") || d.Name.StartsWith("l")).ToList();

//all dogs whose name does not start with L
List<Dog> dogsDoesNotStartWithL = dogs.Where(d => !d.Name.StartsWith("L") && !d.Name.StartsWith("l")).ToList();

Console.WriteLine("===========Starts with L==========");
foreach (Dog dog in dogsStaringWithL)
{
    Console.WriteLine(dog.Name);
}

//Find the first dog older than 2
//First way
Dog firstDogOlderThanTwo1 = dogs.Where(x => x.Age > 2).First(); //get all dogs older than 2 and then return the first one

//Second way 
Dog firstDogOlderThanTwo2 = dogs.First(x => x.Age > 2); //get the first dog older than 2


//Dog dogWithNameOnA = dogs.First(x => x.Name.StartsWith("A")); //this will throw an error : Sequence contains no matching element

Dog dogWithNameOnA = dogs.FirstOrDefault(x => x.Name.StartsWith("A"));
if(dogWithNameOnA != null)
{
    Console.WriteLine($"There is a dog whose name starts with A: {dogWithNameOnA.Name}");
}
else
{
    Console.WriteLine("There is no dog whose name starts with A");
}

//First dog with age 1 whose name starts with L
Dog dogAged1StartingWithL = dogs.FirstOrDefault(x => (x.Name.StartsWith("L") || x.Name.StartsWith("l")) && x.Age == 1);

List<string> dogNames =  dogs.Select(x => x.Name).ToList();

//take the names of all dogs aged 2
//List<string> dogNamesAged2WrongWay = dogs.Select(x => x.Name).Where(//here we are working with IEnumerable<string> (we have only the name, so we cannot use where here to filter by age - string does not have age property)
List<string> dogNamesAged2 = dogs.Where(x => x.Age == 2).Select(x => x.Name).ToList();

List<string> namesOfDogsAged2StartisWithL =
    dogs //here we have the whole List<Dog>
    .Where(x => x.Age == 2) //here we have a collection with dogs aged 2
    .Select(x => x.Name) //here we have IEnumerable<string> with names of dogs aged 2
    .Where(x => x.StartsWith("L")) //here we have a collection with names of dogs aged 2 which start with L
    .ToList(); //here we convert from IEnumerable to List

Dog lastDogAged1 = dogs.Last(x => x.Age == 1); //this might throw an error
Dog lastDogAged1BetterOption = dogs.LastOrDefault(x => x.Age == 1);