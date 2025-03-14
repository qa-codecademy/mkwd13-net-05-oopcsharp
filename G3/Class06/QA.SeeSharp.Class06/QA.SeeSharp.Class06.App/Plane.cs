namespace QA.SeeSharp.Class06.App
{
    public class Plane
    {
        public Plane()
        {
            Console.WriteLine("Default constructor");
        }

        public Plane(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                Name = "N/A";
            }
            Name = name;
            SeatCapacity = 1000;
            Type = "Avion";
            CanFly = false;
            Console.WriteLine("One param Constructor");
        }

        public Plane(string name, int seats, string type, string color, bool canFly)
        {
            Name = name;
            SeatCapacity = seats;
            Type = type;
            Color = color;
            CanFly = canFly;
            Console.WriteLine("All param constructor");
        }

        public string Name { get; set; }
        public int SeatCapacity { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public bool CanFly { get; set; }
    }
}
