namespace QA.SeeSharp.Class06.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.FirstName = "Trajan";
            user.LastName = "Stevkovski";
            Console.WriteLine(user.FirstName);

            Car car = new Car();
            car.Type = "Fiat";
            car.CubicCM = 999;
            car.User = new User();

            // user.SetAge(12); // method is private and its not usable outside the class implementaiton

            Human human = new Human();
            human.FirstName = "Trajan";
            human.LastName = "Stevkovski";
            human.Age = 34;

            Console.WriteLine(human.GetPersonStats());

            Plane plane = new Plane();
            Plane plane1 = new Plane("Avion");
            Plane plane3 = new Plane("Avion1", 100, "Cesna", "Plav", false);

            // USING DEFAULT CONSTRUCTOR BUT ADDING VALUES AFTER THAT
            Plane plane4 = new Plane()
            {
                CanFly = true,
                Name = "Avion",
                Color = "Blue",
                SeatCapacity = 100,
                Type = "Cesna"
            };


            string[] a = new string[5];
            Plane[] b = new Plane[]
            {
                new Plane(),
                new Plane()
            };


            ThisIsAType[] things = new ThisIsAType[]
            {
                new ThisIsAType()
            };

            // Anonymous objects
            var anonymousObj = new
            {
                Name = "Trajan",
                Age = 23,
                IsValid = true
            };

            Console.WriteLine("Hello, World!");
        }
    }
}
