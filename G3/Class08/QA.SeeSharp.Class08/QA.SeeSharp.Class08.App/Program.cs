using System.Collections;
using System.Linq;

namespace QA.SeeSharp.Class08.App
{
    internal class Program
    {
        static void GoTroughCollection(IEnumerable collection, string name)
        {
            Console.WriteLine($"Collection {name} items: ");
            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void PrintDogs(List<Dog> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine($"Name: {item.Name} Age: {item.Age}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Arrays
            string[] strs = new string[4];
            string[] strs2 = new string[] { "Hello", "Bye" };

            // List

            List<string> listOfStrings = new List<string>();
            List<int> listOfNumbers = new List<int>()
            {
                1, 2, 3, 4, 5, 6
            };

            //Console.WriteLine(strs2.Length);
            //Console.WriteLine(listOfNumbers.Count);

            //Console.WriteLine(strs2[0]);
            //Console.WriteLine(listOfNumbers[3]);

            // Adding element in arrays
            Array.Resize(ref strs2, strs2.Length + 1);
            strs2[strs2.Length - 1] = "new element added";
            //GoTroughCollection(strs2, "Niza od string");

            // Adding elements in lists
            listOfNumbers.Add(10);
            listOfNumbers.Remove(3);
            listOfStrings.Add("Trajan");
            listOfStrings.Add("Slave");
            listOfStrings.Add("Bob");
            listOfStrings.Remove("Trajan");

            List<int> numsForAdd = new List<int>() { 6, 1, 3, 5 };
            listOfNumbers.AddRange(numsForAdd);

            listOfNumbers.RemoveRange(5, 2);

            //GoTroughCollection(listOfNumbers, "list of numbers");
            //GoTroughCollection(listOfStrings, "list of strings");

            // Dictionary
            // Dictionary ( Works on Key/Value pair system. This system gives us the option to get values from collection by some key )
            Dictionary<string, string> dictionaryOne 
                = new Dictionary<string, string>();
            Dictionary<int, string> dictionaryTwo = new Dictionary<int, string>();
            Dictionary<double, bool> dictionaryThree 
                = new Dictionary<double, bool>();

            Dictionary<int, string> products = new Dictionary<int, string>()
            {
                { 213213, "Potato" },
                { 123123, "Salt" }
            };

            dictionaryOne.Add("song1", "Wind of change");
            dictionaryOne.Add("song2", "Enter Sandman");
            // Key is always UNIQUE
            // dictionaryOne.Add("song1", "Test");
            //Console.WriteLine(dictionaryOne["song1"]);

            //Console.WriteLine(dictionaryOne.Count);
            dictionaryOne.Remove("song1");
            // TryAdd returns a boolean
            bool isAddedSuccessfully = dictionaryOne.TryAdd("song3", "Song3");

            // Check if key exists
            //Console.WriteLine(dictionaryOne.ContainsKey("song2"));

            //GoTroughCollection(dictionaryOne.Keys, "Keys");
            //GoTroughCollection(dictionaryOne.Values, "Values");


            //GoTroughCollection(dictionaryOne, "DICTIONARY");

            // Queue (First in First out)
            Queue<int> someQueue = new Queue<int>();
            someQueue.Enqueue(25);
            someQueue.Enqueue(3);
            someQueue.Enqueue(111);

            int element = someQueue.Dequeue();
            //Console.WriteLine("Element removed: " + element);
            //Console.WriteLine(someQueue.Peek());
            //GoTroughCollection(someQueue, "QUEUE");
            //Console.WriteLine(someQueue.Count);

            // Stack (Last in first out)
            Stack<string> someStack = new Stack<string>();
            someStack.Push("Hey");
            someStack.Push("Hello");
            someStack.Push("Hi");
            someStack.Push("Zdravo");

            string stackElement = someStack.Pop();
            //Console.WriteLine(stackElement);
            //Console.WriteLine(someStack.Peek());
            //Console.WriteLine("Length: " + someStack.Count);
            //GoTroughCollection(someStack, "STACK");


            //List<User> users = new List<User>();

            // EXERCISES

            Person trajan = new Person()
            {
                FirstName = "Trajan",
                FavoriteMusicType = Genre.Classical,
                Id = 1,
                Age = 23,
                LastName = "Stevkovski"
            };

            Person slave = new Person()
            {
                FirstName = "Slave",
                LastName = "Ivanovski",
                Id = 2,
                Age = 23,
                FavoriteMusicType = Genre.Techno,
                FavoriteSongs = new List<Song>
                {
                   new Song() { Title = "Song1", Length = 10, Genre = Genre.Rock },
                   new Song() { Title = "Song2", Length = 10, Genre = Genre.Techno },
                   new Song() { Title = "Song3", Length = 10, Genre = Genre.Classical },
                }
            };

            //slave.GetFavSongs();
            //trajan.GetFavSongs();


            // LINQ

            List<Dog> dogs = new List<Dog>()
            {
                new Dog(){Name = "Sparky", Age = 2},
                new Dog(){Name = "Butch", Age = 1},
                new Dog(){Name = "Zoe", Age = 3},
                new Dog(){Name = "Sia", Age = 1},
                new Dog(){Name = "William", Age = 4},
                new Dog(){Name = "Billy", Age = 1},
                new Dog(){Name = "Buck", Age = 2}
            };

            // All dogs with name longer than 3 letters
            List<Dog> dogsThatHaveLongerNameThen3Chars = new List<Dog>();
            foreach(Dog dog in dogs)
            {
                if(dog.Name.Length > 3)
                {
                    dogsThatHaveLongerNameThen3Chars.Add(dog);
                }
            }
            PrintDogs(dogsThatHaveLongerNameThen3Chars);

            // Where
            // All dogs with name longer than 3 letters
            List<Dog> filteredDogs = 
                dogs.Where(dog => dog.Name.Length > 3).ToList();
            PrintDogs(filteredDogs);

            // All dogs that have a name starting with S
            List<Dog> startingWithS = dogs
                .Where(dog => dog.Name.StartsWith("S")).ToList();
            PrintDogs(startingWithS);

            // First dog that is of age 1 and have a name that starts with B
            Dog ageOneStartWithB = dogs
                .Where(dog => dog.Age == 1)
                .Where(dog => dog.Name.StartsWith('B'))
                .FirstOrDefault();

            Dog simpleFoD = dogs
                .FirstOrDefault(dog => dog.Age == 1 && dog.Name.StartsWith('B'));

            Console.WriteLine(ageOneStartWithB.Name);
            // Last dog that is of age 1 and have a name that starts with B
            Dog ageOneStartWithBLast = dogs
                .Where(dog => dog.Age == 1)
                .Where(dog => dog.Name.StartsWith('B'))
                .LastOrDefault();
            Console.WriteLine(ageOneStartWithBLast.Name);

            // All names of dogs
            List<string> namesOfDogs = dogs.Select(dog => dog.Name).ToList();
            GoTroughCollection(namesOfDogs, "Dogs");

            // All ages of dogs
            List<int> ages = dogs.Select(dog => dog.Age).ToList();
            GoTroughCollection(ages, "ages");

            // All names of dogs that are the age of 2
            List<string> filteredDogs2 = dogs
                .Where(x => x.Age == 2)
                .Select(x => x.Name)
                .ToList();
            GoTroughCollection(filteredDogs2, "filteredDogs2");

            //Console.ReadLine();
        }
    }
}
