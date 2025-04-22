using AcademyManagement.Domain.Enums;
using AcademyManagement.Domain.Models;
using AcademyManagement.Services;
using AcademyManagement.Services.UserServices;

namespace AcademyManagement.App.UI
{
    public class UserInterface
    {
        private ValidationService _validationService;
        private AdminService _adminService;

        public UserInterface()
        {
            _validationService = new ValidationService();
            _adminService = new AdminService();
        }


        public bool InitApp()
        {

            try
            {
                WelcomeMenu();
                int choice = _validationService.GetValidOption(new int[] { 1, 2, 3 });

                Console.Clear();
                WriteInColor($"Welcome {(Role)choice}. Enter your credentials:\n", ConsoleColor.DarkCyan);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter username:");
                string username = _validationService.GetStringInput();
                Console.WriteLine("Enter password:");
                string password = _validationService.GetStringInput();
                Console.ResetColor();

                switch ((Role)choice)
                {
                    case Role.Admin:
                        Admin loggedAdmin = _adminService.AdminLogin(username, password);
                        WriteInColor($"Hello admin {loggedAdmin.GetFullName()}", ConsoleColor.Green);
                        while (!AdminUI(loggedAdmin)) ;
                        break;
                    case Role.Trainer:
                        break;
                    case Role.Student:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                WriteInColor(ex.Message, ConsoleColor.Red);
            }





            return false;
        }


        public void WelcomeMenu()
        {
            WriteInColor("Welcome to Academy Management", ConsoleColor.DarkCyan);
            WriteInColor("\nChoose your role to login: \n1.Admin \n2.Trainer \n3.Student", ConsoleColor.Cyan);
        }

        public bool AdminUI(Admin loggdInAdmin)
        {
            try
            {
                AdminMainMenu();
                int adminChoice = _validationService.GetValidOption(new int[] { 1, 2, 3, 4 });
                if (adminChoice == 4)
                {
                    return true;
                }
                bool adminActionCompleted = AdminActionMenu((Role)adminChoice, loggdInAdmin);
                if (!adminActionCompleted) 
                {
                    return false;
                }
                Console.ReadLine();
                WriteInColor("Would you like to continue? (Y/N)", ConsoleColor.DarkCyan);
                string input = _validationService.GetStringInput();
                if(input.ToLower() == "y")
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                WriteInColor (ex.Message, ConsoleColor.Red);
            }
            return false;
        }

        public void AdminMainMenu()
        {
            Console.Clear();
            WriteInColor("Welcome to the Admin menu.", ConsoleColor.DarkCyan);
            WriteInColor("\nSelect option: \n1. Manage Admins \n2. Manage Trainers \n3. Manage Students \n4. Logout", ConsoleColor.Cyan);
        }

        public bool AdminActionMenu(Role role, Admin loggedAdmin)
        {
            Console.Clear();
            WriteInColor($"Manage {role} menu.", ConsoleColor.DarkCyan);
            WriteInColor("\nSelect Action: \n1. Add \n2. Remove \n3. Go back", ConsoleColor.Cyan);
            int adminActionChoice = _validationService.GetValidOption(new int[] { 1, 2, 3 });
            switch (adminActionChoice)
            {
                case (int)AdminAction.CreateUser:
                    CreateUserMenu(role);
                    break;
                case (int)AdminAction.DeleteUser:
                    DeleteUserMenu(role, loggedAdmin);
                    break;
                case 3:
                    return false;
            }
            return true;
        }

        public void CreateUserMenu(Role role)
        {
            Console.Clear();
            WriteInColor($"Enter new {role.ToString().ToLower()} data", ConsoleColor.DarkCyan);
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Firstname:");
            string firstName = _validationService.GetStringInput();

            Console.WriteLine("Lastname:");
            string lastname = _validationService.GetStringInput();

            Console.WriteLine("Age:");
            string age = _validationService.GetStringInput();

            Console.WriteLine("Username:");
            string username = _validationService.GetStringInput();

            Console.WriteLine("Password:");
            string password = _validationService.GetStringInput();

            Console.ResetColor();

            _adminService.CreateUser(firstName, lastname, age, username, password, role);

            WriteInColor($"\nUser {username} successfully created!", ConsoleColor.Green);
        }

        public void DeleteUserMenu(Role role, Admin loggedAdmin)
        {
            Console.Clear();
            WriteInColor($"Choose which {role} to delete:\n", ConsoleColor.DarkCyan);
            List<string> users = _adminService.GetUsersToRemove(role, loggedAdmin);
            if(users.Count == 0)
            {
                WriteInColor($"\nNo {role}'s available at the moment for deleting!", ConsoleColor.DarkYellow);
                return;
            }
            for (int i = 0; i < users.Count; i++) 
            {
                Console.WriteLine($"{i+1}. {users[i]}");
            }
            int userToDeleteChoice = _validationService.GetValidOption(Enumerable.Range(1, users.Count).ToArray());
            string selectedUser = users[userToDeleteChoice - 1];
            _adminService.DeleteUser(selectedUser, role);
            WriteInColor(@$"\nSuccessfully deleted {role}: ""{selectedUser}""", ConsoleColor.Green);
        }

        public void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
