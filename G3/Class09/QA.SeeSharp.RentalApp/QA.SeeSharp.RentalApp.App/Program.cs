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
            MovieService _movieService = new MovieService();
            MenuService _menuService = new MenuService();

            User activeUser = null;
            string errorMessage = string.Empty;

            #region Login/SignUp
            _menuService.HomeScreen();
            bool isLogedIn = false;
            while(!isLogedIn)
            {
                _menuService.StartMenu();
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
            #endregion


            while (true)
            {
                _menuService.ClearScreen();
                _menuService.ErrorMessage(errorMessage);
                _menuService.MainMenu(activeUser.FullName);
                string stringSelection = Console.ReadLine();
                var isValidInput = int.TryParse(stringSelection, out int selection);
                if(!isValidInput)
                {
                    Console.WriteLine("Please enter a valid input");
                }
                switch (selection)
                {
                    case 1:
                        _movieService.ViewMovieList(activeUser);
                        break;
                    case 2:
                        _movieService.ViewRentedVideos(activeUser);
                        break;
                    case 3:
                        try
                        {
                            _movieService.ViewRentedHistoryVideos(activeUser);
                        }
                        catch (Exception ex)
                        {
                            errorMessage = ex.Message;
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
        }
    }
}
