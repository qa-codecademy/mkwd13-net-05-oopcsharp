using Qinshift.Generics.Models;


static void PrintUsers(List<User> users)
{
    foreach (User user in users)
    {
        Console.WriteLine($"{user.FirstName} {user.LastName}");
    }
}


#region List - Generic Collections

// Declaration and initialization of array 
string[] namesArr = new string[1] { "Martin" };


// Declaration and initialization of List
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(-3);
numbers.Add(3454);

List<string> names = new List<string>() { "Martin", "Ana", "Frose", "Angel" };
names.Add("Darko");
names.Add("Robert");

List<bool> data = [true, false, true, true, false];

foreach (string name in names)
{
    Console.WriteLine(name);
}

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}


List<User> users = new List<User>
{
    new() { FirstName = "Martin", LastName = "Panovski"},
    new() { FirstName = "Frosina", LastName = "Stamenkovska"},
    new() { FirstName = "Angel", LastName = "Ivanovski"}
};

PrintUsers(users);
users.RemoveAt(2);
users.Add(
        new() { FirstName = "Ana", LastName = "Marjanovikj" }
    );
Console.WriteLine("Users list after remove of items");
PrintUsers(users);


names.Remove("Martin");
names.Remove("Darko");
Console.WriteLine("List names after remove of items:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Add multiple items in an existing collection
names.AddRange(new List<string> { "Jane", "Dejan", "Viktor", "David" });
Console.WriteLine("List names after add of multiple items:");

foreach (string name in names)
{
    Console.WriteLine(name);
}
#endregion


#region Dictionary - Generic Collections

static void PrintDictionary(Dictionary<int, string> students)
{
    Console.WriteLine("Students dictionary:");
    foreach (var student in students)
    {
        Console.WriteLine($"{student.Key}. {student.Value}");
    }
}
static void PrintTodos(Dictionary<string, bool> todos)
{
    Console.WriteLine("Printing my todos:");
    foreach (var todo in todos)
    {
        Console.WriteLine($"{todo.Key} {(todo.Value ? "Done" : "Todo")}");
    }
}

Dictionary<int, string> students = new Dictionary<int, string>()
{
    {1, "Martin" },
    {2, "Frose" },
    {3, "Ana" }
};
students.Add(4, "Angel");
students.Add(5, "Sandra");

PrintDictionary(students);


Dictionary<string, bool> todos = new Dictionary<string, bool>()
{
    {"Get my dog for a walk!", false },
    {"Write Homework!", false },
    {"Buy some milk", true }
};
PrintTodos(todos);

students.ContainsKey(3);
students.ContainsValue("Martin");

students.Remove(2);
Console.WriteLine("Print students after remove of item");
PrintDictionary(students);

students.TryGetValue(2, out string studentName);
Console.WriteLine(studentName);
#endregion


#region Queue - Generic Collections
Queue<int> queue = new Queue<int>();
// Add items to queue
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

// Remove item from queue
// Removes the first inserted item in the queue (FIFO)
int deletedValue = queue.Dequeue();
Console.WriteLine("==== Queue items ====");
foreach (var item in queue)
{
    Console.WriteLine(item);
}
Console.WriteLine($"The next item in the queue is: {queue.Peek()}");
#endregion


#region Stack - Generic Collections
Stack<string> words = new Stack<string>();
words.Push("I");
words.Push("am");
words.Push("learning");
words.Push("C#");
words.Push("language");

Console.WriteLine("===== Stack items ======");
foreach (var word in words)
{
    Console.WriteLine(word);
}
words.Pop();
Console.WriteLine("Stack items after remove:");
foreach (var word in words)
{
    Console.WriteLine(word);
}


#endregion


#region LINQ - Language INtegrated Queires
Console.WriteLine("========================== LINQ ======================");
static void PrintDogs(List<Dog> dogs)
{
    foreach (var dog in dogs)
    {
        Console.WriteLine($"{dog.Name} | {dog.Color} | {dog.Age}");
    }
}



List<Dog> dogs = new List<Dog>
{
    new Dog { Name = "Sparky", Color = "White", Age = 5},
    new Dog { Name = "Butch", Color = "Black", Age = 1},
    new Dog { Name = "Lucy", Color = "White-Brown", Age = 6},
    new Dog { Name = "Zoe", Color = "Grey", Age = 2},
    new Dog { Name = "Blacky", Color = "Black", Age = 1},
};

List<Dog> namesLongerThanThree = dogs.Where(x => x.Name.Length > 3).ToList();
Console.WriteLine("Names longer than 3 letters");
PrintDogs(namesLongerThanThree);

List<Dog> nameStartsWithLetter = dogs.Where(x => x.Name.StartsWith('B')).ToList();
Console.WriteLine("Names that starts with letter B");
PrintDogs(nameStartsWithLetter);


Dog Age1WithB = dogs.Where(x => x.Age == 1)
                    .Where(x => x.Color == "Black")
                    .FirstOrDefault();
Console.WriteLine(Age1WithB.Name);


int sumOfDogsAge = dogs.Sum(x => x.Age);
int oldestInTheList = dogs.Max(x => x.Age);


List<string> dogNamesOfSameAge = dogs.Where(x => x.Age == 1)
                                     .Select(x => x.Name)
                                     .ToList();
Console.WriteLine("Dogs of same age names:");
foreach (var name in dogNamesOfSameAge)
{
    Console.WriteLine(name);
}
#endregion