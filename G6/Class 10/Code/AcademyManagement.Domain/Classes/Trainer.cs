using AcademyManagement.Domain.Enums;

namespace AcademyManagement.Domain.Classes
{
    public class Trainer : AcademyMember
    {
        public Trainer(string username, string firstname, string lastname, int age)
            : base(username, firstname, lastname, age, Role.Trainer) { }
    }
}
