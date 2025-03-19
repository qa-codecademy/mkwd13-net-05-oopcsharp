using System.Collections;

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

            Console.WriteLine(strs2.Length);
            Console.WriteLine(listOfNumbers.Count);

            Console.WriteLine(strs2[0]);
            Console.WriteLine(listOfNumbers[3]);

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

            dictionaryOne.Add("song1", "Wind of change");
            dictionaryOne.Add("song2", "Enter Sandman");
            // Key is always UNIQUE
            // dictionaryOne.Add("song1", "Test");
            Console.WriteLine(dictionaryOne["song1"]);

            Console.WriteLine(dictionaryOne.Count);
            dictionaryOne.Remove("song1");
            // TryAdd returns a boolean
            bool isAddedSuccessfully = dictionaryOne.TryAdd("song3", "Song3");

            // Check if key exists
            Console.WriteLine(dictionaryOne.ContainsKey("song2"));

            //GoTroughCollection(dictionaryOne.Keys, "Keys");
            //GoTroughCollection(dictionaryOne.Values, "Values");


            GoTroughCollection(dictionaryOne, "DICTIONARY");
            //Console.ReadLine();
        }
    }
}
