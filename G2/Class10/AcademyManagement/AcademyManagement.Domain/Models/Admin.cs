using AcademyManagement.Domain.Enums;

namespace AcademyManagement.Domain.Models
{
    public class Admin : User
    {
        public Admin(string firstName, string lastName, string username, string password, int age)
            : base(firstName, lastName, username, password, age)
        {
            Role = Role.Admin;
        }

        public Admin(string username, string password) : base(username, password)
        {
            Role = Role.Admin;
        }
    }
}
