namespace QA.SeeSharp.Class07.App
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        public Vehicle(int id, string model, string type)
        {
            Console.WriteLine("Constructor of Vehicle");
            Id = id;
            Model = model;
            Type = type;
        }

        // can be used every where
        // can be overriden
        public virtual void Drive()
        {
            Console.WriteLine("Im driving");
        }

        // can be used only in classes that inherits from this class 
        protected void StopEngine()
        {
            Console.WriteLine("Stoping engine general");
        }

        // can be see only in the class where is defined
        private void GetInfo()
        {
            Console.WriteLine("Geting info");
        }
    }
}
