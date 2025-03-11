namespace Classes //the path from our sln to our class => in our case the project Classes
{
    public class Person //default is internal
    {
        //we can access FirstName and LastName and Age from anywhere
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //we can access _ssn only from the Person class and its methods
        private long _ssn {  get; set; }

        //Constructor
        //Constructor is public and has the same name as the class
        //we need it in order to instantiate objects
        //we can have more than one constructor
        public Person() {
            _ssn = new Random().Next(100000, 999999); //gets a random number from 100000 to 999999
        }

        public Person(string firstName, string lastName, int age, long ssn) {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            if(ssn >= 100000 && ssn<= 999999)
            {
                _ssn= ssn;
            }
            else
            {
                _ssn = new Random().Next(100000, 999999);
            }
        }

        //we can create more constructors with different params
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = 0;
            _ssn = new Random().Next(100000, 999999);
        }
    }
}
