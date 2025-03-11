
namespace Qinshift.ClassesAndObjects.Models
{
    public class Person
    {
        // This is how we add default constructor (empty constructor)
        // Even if we don't specify it explicitly 
        // C# defines it for us when the class is created
        public Person()
        {
            SSN = GenerateSSN();
        }

        // Constructor for the Person class that can add values through parameters
        public Person(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            SSN = GenerateSSN();
        }


        //  Properties must have type, access modifier and get/set
        public string FirstName { get; set; } = "Martin";
        public string LastName { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        private long GenerateSSN()
        {
            return new Random().Next(100000, 999999); // gets a random number between the values given
        }

        public long GetSSN()
        {
            return SSN;
        }

        // Public method that can be accessed anywhere
        public void Talk(string text)
        {
            Console.WriteLine($"The human named {FirstName} is saying {text}!");
        }
    }
}
