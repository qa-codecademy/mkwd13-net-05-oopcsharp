//Solve the following problem. On one tree there are 12 branches with n apples on them.
//One basket can hold m apples. If a user enters number of trees find out how many baskets does it take
//to collect all the apples from the trees?
//n = 8
//m = 5
//Result = ?

int applesPerBranch = 8;
int applesInBasket = 5;
int numberOfBranchesPerTree = 12;
int result = 0;

Console.WriteLine("Please enter the number of trees:");
bool success = int.TryParse(Console.ReadLine(), out int numberOfTrees); //the input from Console.ReadLine is always a string

if (success)
{
    int numberOfApples = numberOfTrees * numberOfBranchesPerTree * applesPerBranch;
    Console.WriteLine("Number of apples:" +  numberOfApples);

    if(numberOfApples % applesInBasket == 0)
    {
        result = numberOfApples / applesInBasket;
    }
    else
    {
        result = numberOfApples / applesInBasket + 1; //if we have something like 4.1, then we need to add another basket for that .1
    }

    Console.WriteLine($"You need {result} baskets");

}
else
{
    Console.WriteLine("Invalid input! Please enter a valid number!");
}


