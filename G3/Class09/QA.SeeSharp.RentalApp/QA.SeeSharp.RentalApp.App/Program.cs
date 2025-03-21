namespace QA.SeeSharp.RentalApp.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Video Rental App";

            
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
