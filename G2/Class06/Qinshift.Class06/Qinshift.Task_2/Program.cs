using Qinshift.Task_2.Models;

class Program
{
    static User[] users = new User[]
    {
        new User { Id = 1, Username = "Alice", Password = "pass123", Messages = new List<string> { "Hello Alice!", "Your order has been shipped." } },
        new User { Id = 2, Username = "Bob", Password = "secure456", Messages = new List<string> { "Reminder: Meeting at 3PM" } },
        new User { Id = 3, Username = "Charlie", Password = "mypassword", Messages = new List<string> { "Welcome Charlie!", "Your invoice is ready." } }
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an option: 1. Log in  2. Register  3. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Login();
                    break;
                case "2":
                    Register();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void Login()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        foreach (var user in users)
        {
            if (user.Username == username && user.Password == password)
            {
                Console.WriteLine($"Welcome {user.Username}. Here are your messages:");
                foreach (var message in user.Messages)
                {
                    Console.WriteLine(message);
                }
                return;
            }
        }
        Console.WriteLine("Error: Invalid username or password.");
    }

    static void Register()
    {
        Console.Write("Enter new user ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        Console.Write("Enter new username: ");
        string username = Console.ReadLine();
        Console.Write("Enter new password: ");
        string password = Console.ReadLine();

        foreach (var user in users)
        {
            if (user.Username == username)
            {
                Console.WriteLine("Error: Username already exists.");
                return;
            }
        }

        Array.Resize(ref users, users.Length + 1);
        users[users.Length - 1] = new User { Id = id, Username = username, Password = password, Messages = new List<string>() };

        Console.WriteLine("Registration complete! Users:");
        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Username: {user.Username}");
        }
    }
}