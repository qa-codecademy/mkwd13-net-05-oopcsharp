using AcademyManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(string firstName, string lastName, string username, string password, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Age = age;
        }

        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
