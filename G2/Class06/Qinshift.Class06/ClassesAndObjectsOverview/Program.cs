using ClassesAndObjectsOverview.Models;




Academy webDevAcademy = new Academy("Web development", "Full stack web dev academy.");

Group g1 = new Group(20, "Palmyra", "G1");
Group g2 = new Group(15, "Petra");
Group g3 = new Group(18, "Annie", "G3");
Group g4 = new Group(10, "Babylon", "G4");

webDevAcademy.Groups = new Group[] { g1, g2, g3, g4 };


Student martin = new Student("Martin Panovski", 31, g2);
Student frose = new Student("Frosina Stamenkovska", 30, g3);


Console.WriteLine($"The student {martin.FullName} is student in the {martin.Group.Name} group!");
Console.WriteLine($"The student {frose.FullName} is student in the {frose.Group.Name} group!");