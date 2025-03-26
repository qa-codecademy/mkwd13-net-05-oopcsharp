namespace ErrorHandling
{
    public class Human
    {
        public string Name { get; set; }
        public List<Skill> Skills { get; set; }

        public Human(string name) {
            Name = name;
            //for testing null ref. purposes we will not create an empty list here
            //Skills = new List<Skill>();
        }
    }
}
