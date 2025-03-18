namespace Inheritance.Models
{
    public class Cat : Animal
    {
        public bool IsLazy { get; set; } //specific property for the cat class

        //specific only for the cat class => the Animal class does not have a PrintAge method
        public void PrintAge()
        {
            //we can use Age because it is protected in the Animal class and it is inherited by the Cat class
            Console.WriteLine($"The cat is {Age} years old");

            //we cannot use _Id because it is a private property in the Animal class
            //Console.WriteLine($"The cat with Id {_Id} is {Age} years old"); //error
        }

        //first call the default const from the base class (Animal) then execute the default const of the Cat class
        public Cat() : base()
        {
            Console.WriteLine("Calling the default Cat constructor");
        }

        //Override method
        //we need to use the override keyword
        public override void PrintInfo()
        {
            //base.PrintInfo(); //this way we can access the PrintInfo impl from the parent class (we call the PrintInfo method from the Animal (parent) class)

            //this way we tottaly change the impl of the method
            string lazy = IsLazy ? "is lazy" : "isn't lazy";
            Console.WriteLine($"The cat {Name} is {Age} years old and {lazy}");
        }
    }
}
