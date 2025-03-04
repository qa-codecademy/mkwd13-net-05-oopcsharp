using System.ComponentModel.Design;
using System.Globalization;
using System.Transactions;

namespace QA.SeeSharp.Class02.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region variables
            // declaration
            int number;
            Int32 number1 = 10;
            number = 10;

            int num = 10;
            short smallInt = 10;
            byte verySmallInt = 10;
            Int64 biggerInt1 = 1246743564735;
            long biggerInt = 100000000000;

            float floatNumber = 10.10f;
            double doubleNumber = 10.00d;
            decimal decimalNumber = 10.12m;

            char character = 'A';
            string str = "Trajan";

            bool isValid = false;
            bool hasValue = true;

            object obj = 1;
            object obj1 = "asdasdsad";
            object something = true;


            int defaultInt = default;
            Console.WriteLine(defaultInt);
            bool isDefault = default;
            Console.WriteLine(isDefault);

            string str2 = default;
            Console.WriteLine(str2); // DEFAULT value is null

            string str3 = "";
            string str4 = string.Empty;


            // OPERATORS

            //ARITMETIC

            int num1 = 10;
            int num2 = num1 + 10;

            int num3 = num2 + num1;

            int num4 = 10 - 5;
            int num5 = num3 - num4;

            int num6 = 10 / 5;
            double num7 = 10 / 3;

            double a = 10;
            int b = 3;
            double result = a / b;
            Console.WriteLine(result);

            int num8 = 10 * 3;
            int num9 = num8 * num1;

            int num10 = num9 % b;
            Console.WriteLine(num10);

            double res = 4 + 4;

            bool isTrue = true && true && false;
            bool isFalse = false && true && true;

            bool isValid1 = true || false || false && true;

            int z = int.MaxValue;
            int x = int.MaxValue;
            int result10 = z + x;
            Console.WriteLine(result10);

            int num11 = 10;
            num11 = num11 + 1;
            num11++;
            num11 += 1;
            num11 += 5;
            num11 = num11 + 5;

            num11 = num11 - 1;
            num11--;
            num11 -= 1;

            bool isValid10 = true;
            isValid10 &= true;
            isValid10 = isValid10 && true;

            bool isValid11 = true;
            isValid11 |= true;
            isValid11 = isValid11 || true;

            bool isValid12 = !isValid11;
            isValid12 = !isValid12;

            Console.WriteLine("Hello, World!");
            Console.ReadLine();

            #endregion

            #region Parsing
            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            //int parsedNumber = int.Parse(input);
            //Console.WriteLine(parsedNumber);

            //string input1 = Console.ReadLine();

            //bool parsedBool = bool.Parse(input1);
            //Console.WriteLine(parsedBool);

            //string input2 = Console.ReadLine();

            //double parsedDouble = double.Parse(input2);
            //Console.WriteLine(parsedDouble);

            //string input3 = Console.ReadLine();

            //long parsedLong = long.Parse(input3);
            //Console.WriteLine(parsedLong);

            //string input4 = Console.ReadLine();

            //char parsedChar = char.Parse(input4);
            //Console.WriteLine(parsedChar);

            //string input10 = Console.ReadLine();
            //string input11 = Console.ReadLine();

            //int number10 = int.Parse(input10);
            //int number11 = int.Parse(input11);

            //int reulst10 = number10 + number11;
            //Console.WriteLine(reulst10);

            //string input20 = Console.ReadLine();

            //int parsedNumber10 = Convert.ToInt32(input20);
            //Console.WriteLine(parsedNumber10);

            //string input21 = Console.ReadLine();

            //long parsedLong10 = Convert.ToInt64(input21);
            //Console.WriteLine(parsedLong10);

            //string input22 = Console.ReadLine();

            //bool isValid200 = Convert.ToBoolean(input22);
            //Console.WriteLine(isValid200);

            //short parsed = Convert.ToInt16(parsedNumber10);

            //string input30 = Console.ReadLine();

            //int tryParseInteger = default;
            //bool isValidParsing = int.TryParse(input30, out tryParseInteger);

            //bool isValidParsing2 = int.TryParse(input30, out int something1);
            //int sum = something1 + tryParseInteger;
            //Console.WriteLine(sum);

            //Console.WriteLine(isValidParsing);
            //Console.WriteLine(tryParseInteger);

            //string input31 = Console.ReadLine();

            //bool isValidParsingOfBoolean
            //    = bool.TryParse(input31, out bool value);

            //Console.WriteLine(isValidParsingOfBoolean);
            //Console.WriteLine(value);

            //double.TryParse("", out double abc);
            //long.TryParse("", out long abcd);

            //char.TryParse("", out char ad);

            //EXERCISE

            //FROM STRING TO SHORT

            //FROM STRING TO LONG

            //FROM LONG TO SHORT

            //FROM STRING TO DOUBLE

            //FROM DOUBLE TO FLOAT
            #endregion


            // TEMPLATES

            //if (expression)
            //{

            //}

            //if (expression)
            //{

            //} 
            //else
            //{

            //}

            //if (expression)
            //{

            //}
            //else if (second expression) 
            //{

            //}
            //else if (third expression) 
            //{

            //}
            //else
            //{

            //}


            if (3 < 5)
            {
                Console.WriteLine("Im in if statement");
            }

            int num30 = 15;
            int num31 = 10;

            if (num30 <= num31)
            {
                Console.WriteLine("num30 is larger that num31");
            }
            else
            {
                Console.WriteLine("Num31 is larger that num30");
            }

            int budget = 35;

            if (budget >= 75)
            {
                Console.WriteLine("You can go to a fancy restorant");
            }
            else if (budget < 75 && budget >= 50)
            {
                Console.WriteLine("You can go to the movies and get popcorn");
            }
            else if (budget < 50 && budget >= 20)
            {
                Console.WriteLine("You can get a cup of coffee");
            }
            else
            {
                Console.WriteLine("You can stay home");
            }


            // EXCERSISE 5

            int branchesPerTree = 12;
            int applesPerBranch = 8;
            int basketSize = 5;

            Console.WriteLine("Please enter how much trees you have: ");
            string input = Console.ReadLine();

            bool isValidInput = int.TryParse(input, out int trees);

            if (isValidInput)
            {
                int treeApples = (branchesPerTree * applesPerBranch) * trees;
                int baskets = default;
                if (treeApples % basketSize == 0)
                {
                    result = treeApples / basketSize;
                }
                else
                {
                    result = (treeApples / basketSize) + 1;
                }

                Console.WriteLine("You would need : " + result + " baskets!");
            }
            else
            {
                Console.WriteLine("Not a valid input");
            }


            // EXCERSISE 6

            int number100 = 10;
            int number101 = 21;

            int largerNumber = default;

            if (number100 > number101)
            {
                largerNumber = number100;
                Console.WriteLine("The number " + number100 + " is larger then " + number101);
            }
            else
            {
                largerNumber = number101;
                Console.WriteLine("The number " + number101 + " is larger then " + number100);

            }

            if (largerNumber % 2 == 0)
            {
                Console.WriteLine("Is even");
            }
            else
            {
                Console.WriteLine("Is Odd");
            }


            // SWITCH TEMPLATE

            int value = 10;
            // value is concrete vaalue
            switch (value)
            {
                case 1:
                    // lots of code
                    break;
                case 2:
                    // lots of code
                    break;
                default:
                    // lots of code
                    break;
            }

            int dayOfWeek = 3;

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("No such day");
                    break;
            }

            int day = 3;

            switch(day)
            {
                case 1:
                case 3:
                    Console.WriteLine("Academy");
                    break;
                case 2:
                case 4:
                case 5:
                    Console.WriteLine("Free");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("no such day");
                    break;
            }
        }
    }
}