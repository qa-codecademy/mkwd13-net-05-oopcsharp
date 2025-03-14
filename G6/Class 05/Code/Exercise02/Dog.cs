//Add properties: Name, Race, Color
//The dog needs to have an Eat method that returns message: The dog is now eating.
//A Play method returning a message : The dog is now playing.
//and a ChaseTail method that returns a message: Dog is now chasing its tail.


namespace Exercise02
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public Dog() { }

        public string Eat()
        {
            return $"{Name} is now eating";
        }

        public string Play()
        {
            return $"{Name} is now playing";
        }

        public string ChaseTail()
        {
            return $"{Name} is now chasing its tail";
        }
    }
}
