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

double[] doubleArray = new double[] { 3.1, 1.2, 4.78, 6, 0.54 }; //5 elements in the array

Console.WriteLine("Number of elements in the doubleArray: " + doubleArray.Length);

//doubleArray[5] = 6.1; -> we need to resize the array 

//Resize
Array.Resize(ref doubleArray, 7); //I want to change the doubleArray size, so that now it can fit 7 elements, instead of the prevoius 5
Console.WriteLine(doubleArray.Length);
Console.WriteLine(doubleArray[5]);

doubleArray[5] = 6.1;
doubleArray[6] = 3.23;

for(int i = 0; i < doubleArray.Length; i++)
{
    Console.WriteLine(doubleArray[i]); //doubleArray[0], doubleArray[1]..... doubleArray[6]
}

//FOREACH
foreach(double doubleElement in doubleArray)
{
    Console.WriteLine(doubleElement);
}

string[] names = new string[] { "Sinisa", "Viktor", "Ivan", "Olgica" };

foreach(string name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine("========Reversed===========");

Array.Reverse(names);

string firstName = names[0];
Console.WriteLine(firstName);

foreach (string name in names)
{
    Console.WriteLine(name);
}

//Array of arrays

int[][] matrix = new int[][]
{
    new int[] {1, 2},
    new int[] {3, 4},
    new int[] {5, 6},
};
                        //[row] [column]
Console.WriteLine(matrix[2][0]); //5
Console.WriteLine(matrix[1][1]); //4
Console.WriteLine(matrix[0][1]); //2
Console.WriteLine(matrix[1][0]); //3

foreach (int[] row in matrix) //row = int[] {1,2}; int[]{3,4}; int[]{5,6}
{
    Console.WriteLine(row); //we have three arrays Int32[], Int32[], Int32[]

    //we can iterate through the rows (the arrays of the array) with another foreach
    //this way we will iterate through {1,2} in the first iteration, {3,4} in the second iteration and {5,6} in the third iteration
    foreach(int element in row)
    {
        Console.WriteLine(element);
    }
}

//if we want to iterate only in one element of the matrix:
foreach(int element in matrix[0])
{
    Console.WriteLine(element);
}