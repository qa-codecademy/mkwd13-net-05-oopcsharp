using AcademyManagement.Domain.Enums;

namespace AcademyManagement.Domain.Classes
{
    public class Student : AcademyMember
    {
        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject, int> Grades { get; set; }

        public Student(string username, string firstname, string lastname, int age)
            :base(username, firstname, lastname, age, Role.Student) { }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public void PrintDetails()
        {
            Console.WriteLine($"{FirstName} {LastName} {Age}");
            if (CurrentSubject == null)
            {
                Console.WriteLine("The student is currently on a holiday");
            }
            else
            {
                Console.WriteLine($"The current subject is {CurrentSubject.Name}");
            }
            if (Grades == null)
            {
                Console.WriteLine("The student has still no grades");
            }
            else
            {
                Console.WriteLine("Grades:");
                foreach (var item in Grades)
                {
                    Console.WriteLine($"{item.Key.Name} {item.Value}"); // item.Key == subject, item.Value == grade (int)

                }
            }
        }
    }
}
