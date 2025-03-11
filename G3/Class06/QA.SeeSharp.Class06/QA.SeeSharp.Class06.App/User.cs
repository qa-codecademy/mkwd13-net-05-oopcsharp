namespace QA.SeeSharp.Class06.App
{
    public class User
    {
        // PROPERTIES
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // METHODS
        public void PrintFullName()
        {
            Console.WriteLine("Hello");
        }

        public int GetAge(int year)
        {
            SetAge(1);
            return 0;
        }

        private double SetAge(double age)
        {
            return 0;
        }
    }
}
