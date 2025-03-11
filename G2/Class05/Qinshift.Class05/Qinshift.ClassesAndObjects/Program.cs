using Qinshift.ClassesAndObjects.Models;


#region Simple class definition and usage
//string[] array = new string[1];
//Console.WriteLine(array);

User user = new User();
user.UserName = "martinp";
user.Password = "12345";
Console.WriteLine(user.UserName);

#endregion


#region Classes and Objects

Person bob = new Person();
bob.FirstName = "Bob";
bob.LastName = "Bobsky";
bob.Age = 30;
//bob.SSN = 123456789 - This is not possible since the access modifier of SSN in 'private'
bob.Talk("Hey there! We are learning classes and objects!");


Person jill = new Person("Jill", "Wayne", 35);
jill.Talk("Hi there!");
Console.WriteLine(jill.GetSSN());


Person martin = new()
{
    FirstName = "Martin",
    LastName = "Panovski",
    Age = 31,
};





    
#endregion

