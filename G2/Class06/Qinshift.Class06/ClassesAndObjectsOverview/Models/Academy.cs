namespace ClassesAndObjectsOverview.Models
{
    public class Academy
    {
        public Academy(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public Group[] Groups { get; set; }

    }
}
