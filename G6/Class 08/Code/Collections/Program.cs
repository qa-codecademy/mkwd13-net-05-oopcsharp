//Arrays
using System.Collections;

Console.WriteLine("======Arrays=======");
int[] intArray = new int[3]; //allocate memory for 3 ints
string[] stringArray = new string[] { "Hello", "Bye" }; //2 elements

foreach(string str in stringArray)
{
    Console.WriteLine(str);
}

//ArrayList - accepts all types, can have mixed arrauy lists, does not have a constraint about number of elements
Console.WriteLine("======ArrayList=======");
ArrayList arrayList = new ArrayList();//empty array list
ArrayList secondArrayList = new ArrayList { "Hello", 5, true };
secondArrayList.Add("Bye");
secondArrayList.Remove(5); //we send the value of the element we want removed
secondArrayList.RemoveAt(0); //we send the index of the position that we want to remove an element from

//in each iteration item will have the appropriate data type => var will take the data type depending on the value of item
//ex. "Hello" will be string, 5 will be int, true will be bool....
foreach(var item in secondArrayList)
{
    Console.WriteLine(item);
}

for(int i = 0; i< secondArrayList.Count; i++) //Count=> number of elements
{
    Console.WriteLine(i.ToString() +". "+ secondArrayList[i]);
}

//List - all members must be of the same type, does not have constarints about the number of elements
Console.WriteLine("======List=======");
List<int> emptyListOfInts = new List<int>();
List<string> emptyListOfStrings = new List<string>();
List<int> listOfInts = new List<int> { 2, 4, 6 };
listOfInts.Add(5);
listOfInts.Add(-19);
listOfInts.Remove(4); //remove the element with value 4
listOfInts.RemoveAt(0); //remove the element with index 0 (at index/position 0) (here it is the value 2)
Console.WriteLine(listOfInts[2]);
Console.WriteLine($"Number of elements in list of ints: {listOfInts.Count}");

foreach(int number in listOfInts)
{
    Console.WriteLine(number);
}

//Dictionary - works with key value pair
Console.WriteLine("======Dictionary=======");

//we are telling the dictionary that its keys will be of data type ints and its values will be of data type strings
Dictionary<int, string> products = new Dictionary<int, string>() //in Dictionary we don't have indexes
{
    {111, "potato" },
    {222, "milk" },
    {333, "bread" }
};

Console.WriteLine(products[222]); //we use the key the way we used the index - to access the value for that key

products.Add(444, "tea");
products[111] = "coffee";
Console.WriteLine(products[111]);
bool keyExists = products.ContainsKey(222); //returns true or false wheter the products dictionary contains the key  (has an element with that key)
Console.WriteLine(keyExists); //true
products.Remove(333); //we send the value of the key of the element that we want to remove

Console.WriteLine(products.Count);
//var is KeyValuePair
foreach(var item in products)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

//Queue - FIFO (First in First out)
Console.WriteLine("======Queue=======");
Queue<int> queue = new Queue<int>();
queue.Enqueue(5); //add 5 to the end of the queue
queue.Enqueue(19); //add 19 to the end of the queue
queue.Enqueue(100); //add 100 to the end of the queue

int firstElement = queue.Dequeue(); //remove and return the first element (in our case that is 5)
Console.WriteLine(firstElement);

int readFirstElement = queue.Peek(); //only gets the value of the first element, but does not remove the element from the queue
Console.WriteLine(readFirstElement);

foreach(int item in queue)
{
    Console.WriteLine(item);
}

Console.WriteLine(queue.Count);

//Stack - LIFO (Last in First out)
Console.WriteLine("======Stack=======");
Stack<string> stack = new Stack<string>();
stack.Push("Hello"); //add member to the end of the stack
stack.Push("Welcome"); //add member to the end of the stack
stack.Push("Bye"); //add member to the end of the stack

string lastElement = stack.Pop(); //remove and return the last element (in our case - "Bye")
Console.WriteLine(lastElement);

string currentLastElement = stack.Peek(); //read but do not remove the last element (in our case - "Welcome")
Console.WriteLine(currentLastElement);

Console.WriteLine(stack.Count);

foreach(string item in stack)
{
    Console.WriteLine(item);
}