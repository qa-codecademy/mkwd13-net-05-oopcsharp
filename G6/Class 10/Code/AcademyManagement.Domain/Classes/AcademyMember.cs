using AcademyManagement.Domain.Enums;

namespace AcademyManagement.Domain.Classes
{
    public class AcademyMember
    {
        public string Username { get; set; } //unique
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }

        public AcademyMember(string username, string firstname, string lastname, int age, Role role)
        {
            Username = username;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Role = role;
        }
    }
}
