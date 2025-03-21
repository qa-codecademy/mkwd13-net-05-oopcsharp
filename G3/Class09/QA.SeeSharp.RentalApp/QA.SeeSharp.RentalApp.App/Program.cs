using QA.SeeSharp.RentalApp.Business.Services;
using QA.SeeSharp.RentalApp.Data.Models;

namespace QA.SeeSharp.RentalApp.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Video Rental App";

            // GLOBAL VARIABLES
            UserService _userService = new UserService();

            User activeUser = null;

            HomeScreen();
            bool isLogedIn = false;
            while(!isLogedIn)
            {
                StartMenu();
                string input = Console.ReadLine();
                bool isParsedSuccessfully = int.TryParse(input, out int startMenuInput);
                if (!isParsedSuccessfully)
                {
                    Console.WriteLine("Please enter a valid input");
                    continue;
                }
                switch(startMenuInput)
                {
                    case 1:
                        // Login logic
                        activeUser = _userService.Login();
                        if (activeUser == null)
                        {
                            continue;
                        }
                        isLogedIn = !isLogedIn;
                        break;
                    case 2:
                        activeUser = _userService.SignUp();
                        if (activeUser == null)
                        {
                            continue;
                        }
                        isLogedIn = !isLogedIn;
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
        }

        static void HomeScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("==========================================================================");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("==  \\\\    //  || ||||   ||||||  ||||||   ||||||  ||||||  ||  || ||||||  ==");
            Console.WriteLine("==   \\\\  //   || ||  || ||=     ||  ||   ||\\\\    ||=     ||\\\\||   ||    ==");
            Console.WriteLine("==    \\\\//    || ||||   ||||||  ||||||   ||  \\\\  ||||||  ||  ||   ||    ==");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("==========================================================================");
            Console.ResetColor();
        }

        static void StartMenu()
        {
            Console.WriteLine("Welcome to video rent store.");
            Console.WriteLine("Use the numbers in front of the selection to navigate thru the applicaton.");
            Console.WriteLine("1. Rent a movie with existing account.");
            Console.WriteLine("2. Rent a movie and create account.");
            Console.WriteLine("3. Exit application.");
        }
    }
}
