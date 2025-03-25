namespace ErrorHandling
{
    public class Skill
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public Skill(string name, int points)
        {
            Name = name;
            Points = points;
        }
    }
}
