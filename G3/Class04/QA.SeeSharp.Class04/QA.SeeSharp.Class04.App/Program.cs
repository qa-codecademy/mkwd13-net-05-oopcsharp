using System.Xml.Linq;

namespace QA.SeeSharp.Class04.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello("Trajan"); // fnc with no return
            string fullName = GetFullName("Trajan", "Stevkovski"); // fnc that return string
            Console.WriteLine(fullName);

            string fName = "Trajan";
            string lName = "Stevkovski";

            string result = FullName(fName, lName);
            Console.WriteLine(result);

            string[] names = GetNames();
            foreach(string name in names)
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
            for(int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                names[i] = input;
            }

            return names;
        }
    }
}
