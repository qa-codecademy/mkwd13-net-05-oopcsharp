using System.Globalization;
using System.Transactions;

namespace QA.SeeSharp.Class02.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
            
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}