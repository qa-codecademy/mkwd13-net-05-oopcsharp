using QA.SeeSharp.RentalApp.Data.Database;
using QA.SeeSharp.RentalApp.Data.Models;

namespace QA.SeeSharp.RentalApp.Business.Services
{
    public class UserService
    {
        private UserDataService _userDataService;

        public UserService()
        {
            _userDataService = new UserDataService();
        }

        public User Login()
        {
            while(true)
            {
                Console.Write("Enter card number: ");
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int cardNumber);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                // get user;
                User user = _userDataService.GetUserByCardNumber(cardNumber);

                if (user != null)
                {
                    // RenewSubscription
                    Console.WriteLine($"Welcome {user.FullName}");
                    return user;
                }

                // Y y Yes 1 True
                // N n No 0 False
                List<string> confirm = new List<string>() { "Y", "y", "Yes", "1", "True" };
                List<string> decline = new List<string>() { "N", "n", "No", "0", "False" };
                Console.WriteLine("User card id does not exists");
                Console.WriteLine("Do you want to try again?");
                string confirmationInput = Console.ReadLine();
                if (confirm.Contains(confirmationInput))
                {
                    continue;
                } 
                else if (decline.Contains(confirmationInput))
                {
                    return null;
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            }
        }
    }
}
