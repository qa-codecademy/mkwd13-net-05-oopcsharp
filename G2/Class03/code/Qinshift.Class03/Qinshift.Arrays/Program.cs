Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("============== ARRAYS ==============");
Console.ResetColor();


Console.WriteLine("\n======= Creating an array =======\n");
// ===> Array Type Syntax
// e.g. array of integers => int[]
// e.g. array of strings => string[]
// e.g. array of doubles => double[]
// e.g. array of characters => char[]

// 1) Declaring and initializing an array
int[] numbers = new int[] { 11, 22, 1, 2, 33, -5, 3 };
//int[] numbers = { 11, 22, 1, 2, 33, -5, 3 };
Console.WriteLine(numbers[0]); // 11
Console.WriteLine(numbers[4]); // 33

// 2) Declaring an array
string[] students = new string[3];
students[1] = "John";
students[2] = "Zvonko";
students[0] = "Bob";

Console.WriteLine(students[0]);
Console.WriteLine(students[1]);
Console.WriteLine(students[2]);

// students[3] = "Dare"; // EXCEPTION !


Console.WriteLine("\n======= Array Methods =======\n");

// ===> Finding the length of an array (using the Length property)
Console.WriteLine("Numbers array length is " + numbers.Length); // 7

// ===> Sorting an array
//Array.Sort(numbers);
//Console.WriteLine(numbers[6]); // 33
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

// ===> Reversing an array
//Array.Reverse(numbers);
//Console.WriteLine(numbers[0]);

// ===> Searching for an element
int indexOfOne = Array.IndexOf(numbers, 1);
Console.WriteLine($"The index of 1 is {indexOfOne}");
Console.WriteLine(numbers[indexOfOne]); // 1

int indexOfSeven = Array.IndexOf(numbers, 7);
Console.WriteLine($"The index of 7 is {indexOfSeven}"); // -1 => when item is not found in the array, the method IndexOf returns '-1' 



Console.WriteLine("\n======= Adding new items =======\n");
// Arrays have *fixed size*, so we can't directly add elements to them
// Instead, we use resizing 
string[] newStudents = new string[3];
newStudents[0] = "Bob";
newStudents[1] = "John";
newStudents[2] = "Zvonko";

//Array.Resize(ref newStudents, 4);
Array.Resize(ref newStudents, newStudents.Length + 1);
newStudents[3] = "Dare";

Console.WriteLine(newStudents[3]);


// With arrays, each holding 2 whole numbers
int[][] arrayOfArrays = new int[5][]
{
    new int[2] {1, 2},
    new int[2] {3, 4},
    new int[2] {5, 6},
    new int[2] {7, 8},
    new int[2] {9, 12},
};

Console.WriteLine(arrayOfArrays[1][0]);

Console.ReadLine();