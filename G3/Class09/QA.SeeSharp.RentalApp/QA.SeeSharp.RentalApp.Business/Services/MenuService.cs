using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.SeeSharp.RentalApp.Business.Services
{
    public class MenuService
    {
        public void HomeScreen()
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

        public void StartMenu()
        {
            Console.WriteLine("Welcome to video rent store.");
            Console.WriteLine("Use the numbers in front of the selection to navigate thru the applicaton.");
            Console.WriteLine("1. Rent a movie with existing account.");
            Console.WriteLine("2. Rent a movie and create account.");
            Console.WriteLine("3. Exit application.");
        }

        public void MainMenu(string name)
        {
            Console.WriteLine(string.Format("Welcome {0}. What do you want to do today.", name));
            Console.WriteLine("Use the numbers in front of the selection to navigate thru the applicaton.");
            Console.WriteLine("1. View all videos");
            Console.WriteLine("2. View rented videos");
            Console.WriteLine("3. View history");
            Console.WriteLine("4. Exit application");
        }

        public void OrderingMenu()
        {
            Console.WriteLine("Use the numbers in front of the selection to navigate thru the applicaton.");
            Console.WriteLine("1. View all videos");
            Console.WriteLine("2. Order videos by genre");
            Console.WriteLine("4. Order videos by release date");
            Console.WriteLine("5. Get movies by year of release");
            Console.WriteLine("6. Order videos by availability");
            Console.WriteLine("7. Get available videos");
            Console.WriteLine("8. Search videos by title");

            Console.WriteLine("9. Rent a video");
            Console.WriteLine("0. Go back");
        }


        public void ClearScreen()
        {
            Console.Clear();
            HomeScreen();
        }

        public void RentedMenu()
        {
            Console.WriteLine("Use the numbers in front of the selection to navigate thru the applicaton.");
            Console.WriteLine("1. View all videos");
            Console.WriteLine("2. Return video");
            Console.WriteLine("0. Go back");
        }

        public void ErrorMessage(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                Console.WriteLine(errorMessage);
            }
            Console.ResetColor();
        }

    }
}
