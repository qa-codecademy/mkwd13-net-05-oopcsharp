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


        public void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
