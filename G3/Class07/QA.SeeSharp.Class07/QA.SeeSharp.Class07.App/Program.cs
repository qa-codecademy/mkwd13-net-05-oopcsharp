namespace QA.SeeSharp.Class07.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Yellow;

            //WheeledVehicle vehicle = new WheeledVehicle
            //{
            //    Id = 1,
            //    Model = "Yugo",
            //    Type = "Yugo",
            //    Wheels = 4
            //};

            //Car car = new Car
            //{
            //    Id = 2,
            //    Wheels = 4,
            //    Type = "Yugo",
            //    Model = "Yugo",
            //    Color = "Blue",
            //    Doors = 5
            //};

            //Car car = new Car("Yugo", "Yugo", 5, "White");
            //Console.WriteLine();

            //Motorcycle moto = new Motorcycle();

            //car.Drive();
            //moto.Drive();

            //car.Start();
            //moto.Start();

            //car.Stop();

            Car car = new Car("Yugo", "Yugo", 4, "Red", PetrolType.Diesel);

            if(car.PetrolType == PetrolType.LPG)
            {

            }



            Console.WriteLine("Hello, World!");
        }
    }
}
