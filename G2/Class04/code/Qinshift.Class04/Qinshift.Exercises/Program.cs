namespace Qinshift.Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ EXERCISES ============");

            while (true)
            {
                Console.Write("Enter an operation ( + or - ): ");
                string operation = Console.ReadLine();
                if (operation != "+" && operation != "-")
                {
                    Console.WriteLine("Invalid operation. Try again.");
                    continue;
                }
                Console.Write("Enter first number: ");
                string inputFirstNumber = Console.ReadLine();
                bool isFirstNumValid = int.TryParse(inputFirstNumber, out int num1);
                Console.Write("Enter second number: ");
                bool isSecondNumValid = int.TryParse(Console.ReadLine(), out int num2);

                if (!isFirstNumValid || !isSecondNumValid)
                {
                    Console.WriteLine("Enter valid numbers!");
                    continue;
                }

                if (operation == "+")
                {
                    Console.WriteLine(Sum(num1, num2));
                }
                else
                {
                    Console.WriteLine(Subtract(num1, num2));
                }
                break;
            }
            
        }

        #region Exercise 01
        /*
            Create 2 methods called Sum and Subtract
            Sum will accept two numbers as parameters and return a the sum as a result
            Subtract will accept two numbers as parameters and return a subtract result
            Ask a person from the console to enter - or +
            Then ask the person to enter two numbers
            Call the corresponding method ( sum or subtract ) and return the result to the console
         */

        public static int Sum(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        #endregion
    }
}
