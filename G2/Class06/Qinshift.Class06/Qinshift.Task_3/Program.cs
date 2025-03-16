using Qinshift.Task_3.Models;

class Program
{
    static List<Customer> customers = new List<Customer>
        {
            new Customer("Bob Bobsky", 1234123412341234, 4325, 650),
            new Customer("John Johnson", 1111222233334444, 1234, 1200)
        };

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the ATM app");
            Console.WriteLine("Please enter your card number:");
            string cardInput = Console.ReadLine();
            string sanitizedCard = cardInput.Replace("-", "");

            if (!long.TryParse(sanitizedCard, out long cardNumber))
            {
                Console.WriteLine("Invalid card number format.");
                continue;
            }

            Customer currentCustomer = null;
            foreach (var customer in customers)
            {
                if (customer.CardNumber == cardNumber)
                {
                    currentCustomer = customer;
                    break;
                }
            }

            if (currentCustomer == null)
            {
                Console.WriteLine("Card not found. Do you want to register a new card? (yes/no)");
                string registerChoice = Console.ReadLine().ToLower();
                if (registerChoice == "yes")
                {
                    RegisterCustomer(cardNumber);
                }
                continue;
            }

            Console.WriteLine("Enter PIN:");
            if (!int.TryParse(Console.ReadLine(), out int pinInput))
            {
                Console.WriteLine("Invalid PIN format.");
                continue;
            }

            if (!currentCustomer.Authenticate(pinInput))
            {
                Console.WriteLine("Incorrect PIN.");
                continue;
            }

            Console.WriteLine($"Welcome {currentCustomer.FullName}!");

            bool sessionActive = true;
            while (sessionActive)
            {
                Console.WriteLine("What would you like to do:");
                Console.WriteLine("1. Check Balance\n2. Cash Withdrawal\n3. Cash Deposit");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"Your balance is {currentCustomer.GetBalance()}$");
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Enter amount to withdraw: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        {
                            if (currentCustomer.Withdraw(withdrawAmount))
                            {
                                Console.WriteLine($"You withdrew {withdrawAmount}$. You have {currentCustomer.GetBalance()}$ left on your account.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Enter amount to deposit: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            currentCustomer.Deposit(depositAmount);
                            Console.WriteLine($"Deposit successful. Your new balance is {currentCustomer.GetBalance()}$.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.WriteLine("Do you want to perform another action? (yes/no)");
                if (Console.ReadLine().ToLower() != "yes")
                {
                    Console.WriteLine("Thank you for using the ATM app. Goodbye!");
                    sessionActive = false;
                }
                Console.Clear();
            }
        }
    }

    static void RegisterCustomer(long cardNumber)
    {
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();
        Console.Write("Set your PIN: ");
        if (!int.TryParse(Console.ReadLine(), out int newPin))
        {
            Console.WriteLine("Invalid PIN format.");
            return;
        }
        Console.Write("Enter initial deposit: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal initialDeposit))
        {
            Console.WriteLine("Invalid deposit amount.");
            return;
        }

        customers.Add(new Customer(fullName, cardNumber, newPin, initialDeposit));
        Console.WriteLine("Registration successful! You can now log in with your card.");
    }
}