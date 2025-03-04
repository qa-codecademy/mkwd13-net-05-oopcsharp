//FOR

//i++ -> i +=1 -> i = i+1
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Number: " + i);
}

//loops indefinetly unless there is a condition in the block
//infinite loop
//do not forget to break the infinite loop!
for(; ; )
{
    Console.WriteLine("Enter x to exit the loop");
    string input = Console.ReadLine();

    if(input == "x" || input == "X")
    {
        break;
    }
    else
    {
        Console.WriteLine($"input was {input}");
    }

}

//print all numbers except 5 and exit after if gets to 7 (0,1,2,3,4,6,7)
for(int i =0; i <= 10; i++)
{
    if(i == 5)
    {
        continue;//it skips the current iteration and goes back to i++ 
    }

    Console.WriteLine("i: " + i);

    if (i == 7)
    {
        break; //it breaks the for loop (it exists the loop)
    }
}


//WHILE

int counter = 1;
while(counter <= 5)
{
    Console.WriteLine("counter: " + counter);
    counter++; //we need to change the value of counter in order not to enter an infinite loop
}

while (true) //infinite loop
{
    Console.WriteLine("Enter x to exit the loop");
    string input = Console.ReadLine();

    if (input == "x" || input == "X")
    {
        break;
    }
    else
    {
        Console.WriteLine($"input was {input}");
    }
}

//use while, count 1-10, skip 3 and 5
int number = 1;
while(number <= 10)
{
    if(number == 3 || number == 5)
    {
        //careful, put the code for incrementing (moving forward) before continue so we don't enter an infinite loop
        number++;
        continue; //everything after continue is not executed in the current iteration
    }

    Console.WriteLine("number: " + number);
    number++;
}

//DO-WHILE
do
{
    Console.WriteLine("This will be executed at least once!");
} while (false);

