using ErrorHandling;

try
{
    //in try we write the code that we want to be executed and that might throw an error
    Console.WriteLine("Enter a number:");
    string input = Console.ReadLine();

    int number = int.Parse(input);//if we enter a wrong input, this line will throw an exception

    //this line will be executed only if the lines above don't throw an error
    //otherwise we will be redirected to the catch block
    Console.WriteLine(number);
}
catch (Exception ex)
{
    //the catch block will be executed only if an exeception is thrown in the try block
    Console.WriteLine("The input you entered was not a correct number");
  //  Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("This message will be written anyway!");
}

//Throwing an exception
try
{
    Console.WriteLine("Please enter 'a' or 'b'");
    string character = Console.ReadLine();
    if(character.ToLower() == "a" || character.ToLower() == "b")
    {
        Console.WriteLine("Correct input");
    }
    else
    {
        throw new Exception("User did not enter a or b");
    }
    

}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


//Specific exceptions
//ONLY ONE CATCH BLOCK CAN BE EXECUTED AT A TIME
//We have a general Exception and more specific exceptions, we need to otder them from more specific to least specific
try
{
    Console.WriteLine("Enter a number:");
    string input = Console.ReadLine();  
    int number = int.Parse(input);

    //string nullString = null;
    //Console.WriteLine(nullString.Length); //if we don't have a specific catch block, the Exception catch block will handle this exception
}
catch(OverflowException e)
{
    Console.WriteLine("We have more data than what could fit in an int");
}
catch(FormatException e)
{
    Console.WriteLine("The input that was entered was in a wrong format");
}
//catch(NullReferenceException e)
//{
//    Console.WriteLine("Null");
//}
catch(Exception e)// this is the most generic excception, that's why we put it last. All other exceptions inherit from Exception
{
    Console.WriteLine(e.Message);
}

void PrintSkills(Human human)
{
    foreach (Skill skill in human.Skills) //human.Skills might throw an error(for ex. if human is null)
    {
        Console.WriteLine(skill.Name); //skill.Name might throw an error
    }
}

//FIRST OPTION - CALL TO METHOD TO BE IN A TRY-CATCH BLOCK
try
{
    // PrintSkills(null);//this will cause an exception to be thrown on ln 78 - human.Skills will be null.Skills which will throw an exception
   // Human human = new Human("Petko");
   // PrintSkills(human); //we didn't set skills to be an empty list, so the default is null and that will cause an error

}catch(Exception e)
{
    Console.WriteLine("We are here because PrintSkills thre an exception");
}

//SECOND OPTION - Handle the exception i the method
void PrintHumanSkills(Human human)
{
    try
    {
        foreach (Skill skill in human.Skills) //human.Skills might throw an error(for ex. if human is null)
        {
            Console.WriteLine(skill.Name); //skill.Name might throw an error
        }

    }
    catch (Exception e)
    {
        Console.WriteLine("We are handling the excewptions inside the method");
    }
}

PrintHumanSkills(null);