//array of whole numbers, containing 3 elements
int[] arrayOfInts = new int[3]; //here 3 is not an index, it represents the number of elements (members of the array)

arrayOfInts[0] = 1; //initialize the first element
arrayOfInts[1] = 6; //initialize the second element
//arrayOfInts[2] = 13; //initialize the thrid element

Console.WriteLine("First element " + arrayOfInts[0]);
Console.WriteLine("Third element " + arrayOfInts[2]);

//declare and initialize the array
//C# from the given values will see how many elements we have in the array
string[] arrayOfStrings = new string[] { "Hello", "G6", "C#", "arrays", "Goodbye!" };

Console.WriteLine(arrayOfStrings[3]);

short[] arrayOfShorts = new short[] { 1, 2, 5, 8 };
bool[] arrayOfBools = new bool[] { false, true, false };

bool[] anotherArrayOfBools = new bool[2];
anotherArrayOfBools[0] = true;
anotherArrayOfBools[1] = false;

Console.WriteLine("Number of elements in anotherArrayOfBools: " + anotherArrayOfBools.Length);
Console.WriteLine("Number of elements in arrayOfShorts: " + arrayOfShorts.Length);

int indexOf6 = Array.IndexOf(arrayOfInts, 6);
Console.WriteLine("The index of 6 in arrayOfInt is: " + indexOf6);

int indexOf12 = Array.IndexOf(arrayOfInts, 12);
Console.WriteLine("The index of 12 in arrayOfInt is: " + indexOf12); //it will return -1 if the value does not exist

int indexOfTrue = Array.IndexOf(arrayOfBools, true);
Console.WriteLine(indexOfTrue);

int indexOf8 = Array.IndexOf(arrayOfShorts, (short)8); //we must cast 8 to a short, because by default the 8 is considered an int, and we try to compare short 8 with int 8 which is not the same
Console.WriteLine(indexOf8);
