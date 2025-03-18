namespace QA.SeeSharp.Class07.App
{
    public class Motorcycle : WheeledVehicle
    {
        public string Color { get; set; }

        public Motorcycle()
            : base(1, "Yamaha", "Motor", 2, PetrolType.Electric)
        {
            
        }

        public override void Drive()
        {
            Console.WriteLine("Im driving a motorcycle");
        }
    }
}
