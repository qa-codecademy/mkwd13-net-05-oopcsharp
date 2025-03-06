//Declare a new array of integers with 5 elements
//Initialize the array elements with values from input
//Sum all the values and print the result in the console

int[] ourIntArray = new int[5]; //here we only tell it that ourIntArray will have 5 elements


//Initialize the array elements with values from input
for(int i = 0; i<ourIntArray.Length; i++)
{
    Console.WriteLine("Please enter a value for index: " + i);
    bool success = int.TryParse(Console.ReadLine(), out ourIntArray[i]); //here, if the parse is not succcessful, it will put the value 0 in ourIntArray[i]

    //string input = Console.ReadLine();
    //bool success2 = int.TryParse(input, out int number);
    //if (success2)
    //{
    //    ourIntArray[i] = number;
    //}
    //else
    //{
    //    Console.WriteLine("Wrong input!");
    //    break;
    //}
}

int sum = 0;
foreach(int item in ourIntArray)
{
    sum += item;
}

Console.WriteLine("The sum is: " + sum);