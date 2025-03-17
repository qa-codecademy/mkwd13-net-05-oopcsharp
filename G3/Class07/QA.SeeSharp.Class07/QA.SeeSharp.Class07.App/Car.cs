namespace QA.SeeSharp.Class07.App
{
    public class Car : WheeledVehicle
    {
        public int Doors { get; set; }
        public string Color { get; set; }

        public Car(string model, string type, int wheels, string color, PetrolType petrol)
            : base(1, model, type, wheels, petrol)
        {
            Console.WriteLine("Constructor of Car");
            Color = color;
            Doors = 5;
        }

        public override void Drive()
        {
            Console.WriteLine("Im driving a car");
        }

        public override void Start()
        {
            Console.WriteLine("In car class");
            base.Start();
            Console.WriteLine("brm brm");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping car engine");
            StopEngine();
        }
    }
}
