using AcademyManagement.Domain.Enums;

namespace AcademyManagement.Domain.Models
{
    public class Trainer : User
    {
        public Trainer(string firstName, string lastName, string username, string password, int age)
            : base(firstName, lastName, username, password, age)
        {
            Role = Role.Trainer;
        }


        public Trainer(string username, string password) : base(username, password)
        {
            Role = Role.Trainer;
        }
    }
}
