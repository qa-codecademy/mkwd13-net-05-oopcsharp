using Exercise03;

Student[] students = new Student[]
{
    new Student("Sinisa", "Qinshift", "G6"),
    new Student("Viktor", "Qinshift", "G6"),
    new Student("Ivan", "Qinshift", "G6"),
    new Student("Olgica", "Qinshift", "G6"),
    new Student("Martin", "Qinshift", "G6"),
};

Console.WriteLine("Please enter a student name:");
string name = Console.ReadLine(); //sinisa, SINISA, Sinisa
Student student = FindStudent(students, name); //check if the students exists

if(student != null)
{
    student.PrintInfo();
}
else
{
    Console.WriteLine($"Student with name {name} was not found");
}

Student FindStudent(Student[] studentArray, string name)
{
    foreach (Student student in studentArray)
    {
        if(student.Name.ToLower() == name.ToLower())
        {
            return student;
        }
    }

    return null; //after we iterate the whole array, if there was no match (it did not go in the if statement), we return null
}