namespace Qinshift.Inheritance.Models
{
    public class Dog : Animal
    {
        public Dog(string name, string type, string color, string breed) 
            : base(name, type, color)
        {
            Console.WriteLine("Dog constructor executed");

            Breed = breed;
        }

        public Dog(string name) : base(name) { }

        // This Dog class will have every property and method
        // from class Animal

        // This property will be unique to Dog class
        public string Breed { get; set; }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the {Breed} says wooof wooof!!!");
        }

    }
}
