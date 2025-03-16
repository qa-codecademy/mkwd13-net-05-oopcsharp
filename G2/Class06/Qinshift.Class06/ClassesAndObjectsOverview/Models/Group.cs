namespace ClassesAndObjectsOverview.Models
{
    public class Group
    {
        public Group()
        {
        }

        public Group(int numberOfStudents, string classroomName, string name = "G2")
        {
            Name = name;
            NumberOfStudents = numberOfStudents;
            ClassroomName = classroomName;
        }

        public string Name { get; set; } = "G2";
        public int NumberOfStudents { get; set; }
        public string ClassroomName { get; set; }
    }
}
