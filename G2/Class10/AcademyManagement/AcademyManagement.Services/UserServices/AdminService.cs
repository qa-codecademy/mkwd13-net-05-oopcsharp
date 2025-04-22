
using AcademyManagement.Domain;
using AcademyManagement.Domain.Enums;
using AcademyManagement.Domain.Models;

namespace AcademyManagement.Services.UserServices
{
    public class AdminService
    {
        private DataAccess _dataAccess;

        public AdminService()
        {
            _dataAccess = new DataAccess();
        }

        //Login
        public Admin AdminLogin(string username, string password)
        {
            Admin adminFromDb = _dataAccess.GetAdmin(username, password);
            if(adminFromDb == null)
            {
                throw new Exception("Invalid credentials entered. Try again.");
            }
            return adminFromDb;
        }

        //CreateUser
        public void CreateUser(string firstName, string lastName, string age, string username, string password, Role role)
        {
            bool userExists = _dataAccess.CheckIfUserExsists(username, role);
            if (userExists)
            {
                throw new Exception($@"{role} with ""{username}"" already exists!");
            }
            _dataAccess.CreateNewUser(firstName, lastName, age, username, password, role);
        }

        //GetUsersToRemove
        public List<string> GetUsersToRemove(Role role, Admin loggedAdmin)
        {
            return _dataAccess.GetUsernames(role, loggedAdmin);
        }

        //DeleteUser
        public void DeleteUser(string username, Role role)
        {
            bool userExsists = _dataAccess.CheckIfUserExsists(username, role);
            if (!userExsists)
            {
                throw new Exception($"Cannot delete not existing user with username: {username}");
            }
            _dataAccess.DeleteUser(username, role);
        }
    }
}
