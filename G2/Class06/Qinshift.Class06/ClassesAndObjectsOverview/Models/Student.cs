namespace ClassesAndObjectsOverview.Models
{
    public class Student
    {
        public Student(string fullName, int age, Group group)
        {
            FullName = fullName;
            Age = age;
            Group = group;
        }

        public Student(string fName, string lName, int age)
        {
            FullName = $"{fName} {lName}";
            Age = age;
        }

        public string FullName { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }
    }
}
