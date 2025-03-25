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
                    // TODO: RenewSubscription
                    // RenewSubscription
                    RenewSubscription(user);
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

        public User SignUp()
        {
            while(true)
            {
                Console.WriteLine("Enter full name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter date of birth (day-month-year 12-3-1999)");
                string dob = Console.ReadLine();
                bool isValidDate = DateTime.TryParse(dob, out DateTime dateOfBirth);
                if (!isValidDate)
                {
                    Console.WriteLine("Please enter a valid input");
                    continue;
                }

                int cardNumber = GenerateCardNumber();
                User user = new User()
                {
                    CardNumber = cardNumber,
                    FullName = name,
                    DateOfBirth = dateOfBirth
                };
                Console.WriteLine(string.Format("Welcome {0}", user.FullName));
                _userDataService.InsertNewUser(user);

                return user;
            }
        }

        private int GenerateCardNumber()
        {
            Random rand = new Random();

            // get all card numbers that exists in memoryDB
            List<int> existingCardNumbers = _userDataService.GetAllCardNumbers();

            int cardNumber = default;
            do
            {
                cardNumber = rand.Next(100, 999);
            }
            while (existingCardNumbers.Contains(cardNumber));

            return cardNumber;
        }

        private void RenewSubscription(User user)
        {
            if (user.SubscriptionExpireTime < DateTime.Now)
            {
                user.IsSubscriptionExpired = true;
            }

            if (user.IsSubscriptionExpired)
            {
                Console.WriteLine("Your subscription has expired. Do you want to renew it y/n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    user.IsSubscriptionExpired = false;
                    user.SubscriptionExpireTime = DateTime.Now.AddDays(7);
                    Console.WriteLine($"Your subscription is extended until {user.SubscriptionExpireTime.ToShortDateString()}");
                }
                else
                {
                    Console.WriteLine("Thank you for using Video rental");
                    Environment.Exit(0);
                }
            }
        }
    }
}
