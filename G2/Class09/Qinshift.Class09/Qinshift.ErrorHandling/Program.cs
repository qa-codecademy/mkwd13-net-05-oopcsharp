
using Qinshift.ErrorHandling.Models;

//#region Exceptions

//// Type of General exception. All the information are kept in ex variable so we
//// can access them



//Console.WriteLine("====== Number Example ======");
//Console.WriteLine("Enter a number:");

//try
//{
//    int number = int.Parse(Console.ReadLine());
//    Console.WriteLine($"The number you entered is number: {number}");
//}
//catch (Exception ex)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Wrong input. Try again to enter a valid number!");
//    Console.WriteLine($"Exception Message: {ex.Message}");
//}
//finally
//{
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.WriteLine("The Number example finished!");
//    Console.ReadLine();
//}



//// Self thrown exceptions on purpose

//Console.WriteLine("====== Self thrown Exception =====");
//Console.WriteLine("Enter a letter a or b");

//try
//{
//    string letter = Console.ReadLine().ToLower().Trim();
//    if(letter == "a" || letter == "b")
//    {
//        Console.WriteLine("Congratulations, you have entered a or b!");
//    }
//    else
//    {
//        // If this is not inside try/catch it will break the application just like 
//        // any other exception thorwn.
//        throw new Exception("That was not letter a nor letter b! Sorry!");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Pres any key to exit.");
//    Console.ReadLine();
//}



//Console.WriteLine("===== Handling specific exceptions! =====");
//try
//{
//    Console.WriteLine("Enter some character!");
//    char char1 = char.Parse(Console.ReadLine());
//    Console.WriteLine($"You have entered the character: {char1}");

//    int[] numbers = new int[2] { 1, 2 };
    
//    Console.WriteLine("Please enter two numbers:");
//    int num1 = int.Parse(Console.ReadLine());
//    int num2 = int.Parse(Console.ReadLine());
//    Console.WriteLine("The difision of the numbers is: " + num1/num2);

//}
//catch (FormatException ex)
//{
//    Console.WriteLine("You have entered something other than a character!");
//}
//catch(IndexOutOfRangeException ex)
//{
//    Console.WriteLine("Array out of range. Cannot insert numbers in the array!");
//}
//catch(DivideByZeroException ex)
//{
//    Console.WriteLine("You try to divide with zero! Please don't do that!");
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Error occured! Try again later!");
//}





//#endregion


#region Exceptions from methods

// Ecxeption handling inside a function (lower level)
static void HumanSkill1(Human human)
{
    try
    {
        foreach (var item in human.Skills)
        {
            Console.WriteLine(item.Name);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Catch inside the function: {ex.Message}");
    }
}


// Exception handling propagation (exception will be sent to the higher level)
static void HumanSkill2(Human human)
{
    foreach (var item in human.Skills)
    {
        Console.WriteLine(item.Name);
    }
}

Human h1 = new Human() { Name = "Bob" };

HumanSkill1(h1);

try
{
    HumanSkill2(h1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}







#endregion