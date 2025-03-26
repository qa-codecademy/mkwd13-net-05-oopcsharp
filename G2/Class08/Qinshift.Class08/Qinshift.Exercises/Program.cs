#region Exercise 1

static void SearchPhoneBook(Dictionary<string, long> phoneBook, string name)
{
    if(!phoneBook.ContainsKey(name))
    {
        Console.WriteLine("No such contact found! Sorry!");
        return;
    }
    Console.WriteLine($"{name}'s phone is: 0{phoneBook[name]}");
}

Dictionary<string, long> phoneBook = new Dictionary<string, long>()
{
    { "Martin", 070222333 },
    { "Bob", 078222333 },
    { "Jill", 077123444 },
    { "Petre", 071123678 },
};

while (true)
{
    Console.WriteLine("Please enter a name:");
    string userInput = Console.ReadLine();

    SearchPhoneBook(phoneBook, userInput);
    Console.WriteLine("Do you need another contact to search? Y or N?");
    string choice = Console.ReadLine();
    if (choice.ToLower() == "n")
        break;
    Console.Clear();
}


#endregion