using System.Data.SqlTypes;

namespace QA.SeeSharp.Class04.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise01();

            Console.ReadLine();
            //Console.Write("Please enter number: ");
            //Console.ReadLine();

            SayHello("Trajan"); // fnc with no return
            string fullName = GetFullName("Trajan", "Stevkovski"); // fnc that return string
            Console.WriteLine(fullName);

            string fName = "Trajan";
            string lName = "Stevkovski";

            string result = FullName(fName, lName);
            Console.WriteLine(result);

            string[] names = GetNames();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public static string GetFullName(string fName, string lName)
        {
            string fullName = fName + " " + lName;
            return fullName;
        }

        public static string GetFirstName(string fName)
        {
            return fName + " FIRST NAME";
        }

        public static string GetLastName(string lName)
        {
            return lName + " LAST NAME";
        }

        public static string FullName(string fName, string lName)
        {
            string result = GetFirstName(fName);
            string result1 = GetLastName(lName);

            return result + " " + result1;
        }

        public static int GetAge(string name, double year, char gender)
        {
            return 0;
        }

        public static string[] GetNames()
        {
            string[] names = new string[10];
            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                names[i] = input;
            }

            return names;
        }
        // EXERCISE 01
        public static void Exercise01()
        {
            string operation = GetOperator();
            int number1 = GetNumber("Please enter the first number");
            int number2 = GetNumber("Please enter the second number");
            Calculator(operation, number1, number2);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static string GetOperator()
        {
            bool isValidOperator = false;
            string operation = string.Empty;
            while (!isValidOperator)
            {
                Console.WriteLine("Please enter operation (+/-)");
                operation = Console.ReadLine();
                if (operation == "+" || operation == "-")
                {
                    isValidOperator = true;
                }
            }
            return operation;
        }

        public static int GetNumber(string message)
        {
            Console.WriteLine(message);
            int number = default; // 0
            while (true)
            {
                string input = Console.ReadLine();
                bool isValidInput = int.TryParse(input, out number);
                if (isValidInput)
                {
                    break;
                }
            }
            return number;
        }

        public static void Calculator(string operation, int a, int b)
        {
            switch(operation)
            {
                case "+":
                    Console.WriteLine(Sum(a, b));
                    break;
                case "-":
                    Console.WriteLine(Substract(b, a));
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
