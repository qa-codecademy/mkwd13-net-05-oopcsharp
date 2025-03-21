//Create a PhoneBook Dictionary with 5 names and phone numbers. 
//Through the console ask the person to enter a name.
//Try and find that names phone number in your PhoneBook
//If you can find it, print it in the console
//If you can’t, print an error message

Dictionary<string, long> phoneBook = new Dictionary<string, long>() //the phone number can also be a string
{
    {"Petko", 070123123 }, //the leading 0 will not be printed, if we want to see the 0, we need to make the phone number a string
    {"Nikola", 070456456 },
    {"Stefan", 070789789 },
    {"Ana", 070147147 },
    {"Marko", 070258258 }
};

Console.WriteLine("Enter a name:");
string input  = Console.ReadLine(); //if we only click Enter it will have the value of an empty string

//if(input == null || input == '')  //'' means empty string
//'' != ' '//the first one is an empty string and the second one is a space character
if (string.IsNullOrEmpty(input)) //check if the input is an empty string or a null value for validation
{
    Console.WriteLine("Invalid input");
}
else
{
    //ONE WAY
    bool isFound = false;
    foreach (var phone in phoneBook)
    {
        if (phone.Key.ToLower() == input.ToLower())
        {
            isFound = true;
            Console.WriteLine(phone.Value);
            break; //we do not need to iterate anymore if we found the name as the key must be unique
        }
    }
    if (!isFound)
    {
        Console.WriteLine("No phone number found");
    }


    //SECOND WAY
    if (phoneBook.ContainsKey(input))//check if the dictionary contains a record with a key that is the same as the input
    {
        Console.WriteLine($"The phone number of {input} is {phoneBook[input]}"); //get the value using the input as the key
    }
    else
    {
        Console.WriteLine("No phone number found");
    }

}