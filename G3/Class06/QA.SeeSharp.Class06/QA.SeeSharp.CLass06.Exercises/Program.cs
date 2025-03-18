namespace QA.SeeSharp.CLass06.Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number number = new Number(20.5);
            //number.PrintNumberStats();

            User[] users = new User[] { new User(1, "test", "test") };

            bool isActiveApp = true;
            while(isActiveApp)
            {
                Console.WriteLine(@"
                1. Register
                2. Login
                3. Exit");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int action))
                {
                    switch(action)
                    {
                        case 1:
                            Console.Write("Enter username: ");
                            string username = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Enter password: ");
                            string password = Console.ReadLine();
                            Console.WriteLine();
                            Register(username, password, users);
                            break;
                        case 2:
                            Console.Write("Enter username: ");
                            string user = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Enter password: ");
                            string pass = Console.ReadLine();
                            Login(user, pass, users);
                            break;
                        case 3:
                            isActiveApp = !isActiveApp;
                            break;
                        default:
                            Console.WriteLine("Plese choose a valid action");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid action");
                }
            }

            Console.WriteLine("Hello, World!");
        }

        public static void Register(string username, string password, User[] users)
        {
            User user = FindUser(username, users);
            if (user != null)
            {
                Console.WriteLine("User already exists");
                return;
            }

            Array.Resize(ref users, users.Length + 1);
            User newUser = new User(users.Length + 1, username, password);
            users[users.Length - 1] = newUser;

            Console.WriteLine("Successfully registered");
            Console.WriteLine("-----------------------");
        }

        public static void Login(string username, string password, User[] users)
        {
            User user = FindUser(username, users);
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            if (user.Password != password)
            {
                Console.WriteLine("Invalid username or password");
                return;
            }

            Console.WriteLine("-----------------");
            Console.WriteLine($"Welcome {user.Username}");

            foreach(string message in user.Messages)
            {
                Console.WriteLine(message);
            }
        }

        public static User FindUser(string username, User[] users)
        {
            foreach(User user in users)
            {
                if (user.Username.ToLower() == username.ToLower())
                {
                    return user;
                }
            }
            return null;
        }
    }
}
