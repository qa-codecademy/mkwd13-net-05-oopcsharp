namespace Qinshift.Exercise1.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human()
        {
            
        }

        public Human(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
        }


        public string GetPersonStats()
        {
            return $"{GetFullName()} - {Age}";
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
