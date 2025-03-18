
using Enums;
using System.Runtime.CompilerServices;

int day = 5;

if(day == 5) //NOT A GOOD PRACTICE, NOT CLEAR
{
    Console.WriteLine("Yay it is Friday!");
}

if(day == (int)DayOfWeekEnum.Friday) //we need to convert (cast, get the value from the enum) the enum to int so that we can compare it with another int 
{
    Console.WriteLine("Yay it is Friday!");
}

int roleNumber = 1;

if (roleNumber == (int)RoleEnum.Administrator)
{
    Console.WriteLine($"This is the {RoleEnum.Administrator.ToString()}");
}
else if (roleNumber == (int)RoleEnum.User)
{
    Console.WriteLine($"This is the {RoleEnum.User.ToString()}");
}

RoleEnum tmp = RoleEnum.Administrator;

//(int)RoleEnum.Administrator; //=> this way we get the value (number value) of the enum
//RoleEnum.Administrator.ToString();// => This way we get the string value (the name) of the enum
