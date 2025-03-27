using AcademyManagement.Domain.Enums;

namespace AcademyManagement.Domain.Classes
{
    public class Admin : AcademyMember
    {
        public Admin(string username, string firstname, string lastname, int age)
            : base(username, firstname, lastname, age, Role.Admin) { }
    }
}
