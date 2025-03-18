namespace Inheritance.Models
{
    public class Dog : Animal
    {
        public string Color { get; set; }

        public Dog (string name, string color) : base("Dog") //it will call the cosnst with param string type from the base (Animal) class
        {
            Name = name; //this is a property from the parent class, but we can give it value here
            Color = color;
        }

        public Dog() //: base()
        {
            Console.WriteLine("Calliing the default dog constructor");
        } 
    }
}
