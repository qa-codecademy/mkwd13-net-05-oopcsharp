//Create an array with names
//Give an option to the user to enter a name from the keyboard
//After entering the name put it in the array
//Ask the user if they want to enter another name(Y / N)
//Do the same process over and over until the user enters N
//Print all the names after user enters N

string[] names = new string[0]; //empty array => 0 represents the number of elements
//string[] names2 = new string[] {}; //empty array

int i = 0;

while (true)
{
    Console.WriteLine("Enter a name:");
    string name = Console.ReadLine();

    //we need to change the size of our array
    Array.Resize(ref names, names.Length + 1); //in the first iteration the length will be 0 and we want to make it 1, then in the second iteration the length wil be 1 and we will want to make it 2...
    names[i] = name; //we initialize the array element with the input
    i++; //we increment the counter
    //names[names.Length - 1] = name; //another way without counter: names.Length - 1 is always the index of the last element

    Console.WriteLine("Do you want to enter another name (Y/N)?");
    string input = Console.ReadLine();
    if(input == "n" || input == "N")
    {
        break;
    }
}

//do
//{
    //logic
//}while(input != "n" && input != "N");