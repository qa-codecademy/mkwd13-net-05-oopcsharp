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
            num11 ++;
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

            string input30 = Console.ReadLine();

            int tryParseInteger = default;
            bool isValidParsing = int.TryParse(input30, out tryParseInteger);

            bool isValidParsing2 = int.TryParse(input30, out int something1);
            int sum = something1 + tryParseInteger;
            Console.WriteLine(sum);

            Console.WriteLine(isValidParsing);
            Console.WriteLine(tryParseInteger);

            string input31 = Console.ReadLine();

            bool isValidParsingOfBoolean
                = bool.TryParse(input31, out bool value);

            Console.WriteLine(isValidParsingOfBoolean);
            Console.WriteLine(value);

            double.TryParse("", out double abc);
            long.TryParse("", out long abcd);

            char.TryParse("", out char ad);


        }
    }
}