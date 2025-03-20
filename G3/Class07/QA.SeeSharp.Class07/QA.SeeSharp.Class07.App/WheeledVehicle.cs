namespace QA.SeeSharp.Class07.App
{
    public class WheeledVehicle : Vehicle
    {
        public int Wheels { get; set; }
        public PetrolType PetrolType { get; set; }

        public WheeledVehicle(int id, string model, string type, int wheels, PetrolType petrol)
            : base(id, model, type)
        {
            Console.WriteLine("Constructor of WheeledVehicle");
            Wheels = wheels;
            PetrolType = petrol;
        }

        public WheeledVehicle(string model)
            : base(10, model, "Type")
        {
            Wheels = 2;
        }

        public virtual void Start()
        {
            Console.WriteLine("Starting engine");
        }
    }
}
