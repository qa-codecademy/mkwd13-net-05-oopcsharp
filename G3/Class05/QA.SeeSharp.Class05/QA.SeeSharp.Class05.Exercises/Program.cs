namespace QA.SeeSharp.Class05.Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Substrings();
            Console.WriteLine("Hello, World!");
        }

        static void Substrings()
        {
            string str = "Hello from SEDC Codecademy 2025";
            string input = Console.ReadLine();
            int length = int.Parse(input);

            string newString = str.Substring(0, length);

            Console.WriteLine(
                string.Format(
                    "New String is \"{0}\" and the length of the new string is: {1}",
                    newString, newString.Length));
        }
    }
}
