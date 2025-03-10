namespace QA.SeeSharp.Class05.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONCATENATION
            string a = "Trajan " + "Stevkovski";

            string name = "Bob";
            string lastName = "Bobski";

            string fullName = name + " " + lastName;
            Console.WriteLine(fullName);

            //"Hello name, how are you today";

            string str = "Hello" + name + " , how are you today";
            // STRING FOMRATING
            string str2 = string.Format("Hello {0}, how are you today", name);
            Console.WriteLine(str);
            Console.WriteLine(str2);
            string str3 = string
                .Format("Hello {0} {1}, How are you today?", name, lastName);
            Console.WriteLine(str3);
            string str4 = string
                .Format("{0} {1} {2} {3} {4} {5}", "a", "b", "c", "d", "e", "f");
            Console.WriteLine(str4);

            // STRING INTEPOLATION
            string str5 = $"Hello {name} {lastName}. How are you today(INTERPOLATION)";
            Console.WriteLine(str5);

            // ESCAPE CHARATERS
            string str6 = "http:\\\\google.com";
            string str7 = @"http:\\google.com";
            Console.WriteLine(str6);
            Console.WriteLine(str7);

            // Multi line string with @
            string str8 = "Lorem Ipsum is simply dummy text of t" +
                "he printing and typesetting industry. Lorem Ips" +
                "um has been the industry's standard dummy text " +
                "ever since the 1500s, when an unknown printer took " +
                "a galley of type and scrambled it to make a type " +
                "specimen book. It has survived not only five centuries," +
                " but also the leap into electronic typesetting, remaining " +
                "essentially unchanged. It was popularised in";
            string str9 = @"Lorem Ipsum is simply dummy text
                of the printing and typesetting industry. Lorem Ipsum has been
                the industry's standard dummy text ever since the 1500s, when an
                unknown printer took a galley of type and scrambled it to make a
                type specimen book. It has survived not only five centuries, but 
                also the leap into electronic typesetting, remaining essentially 
                unchanged. It was popularised in";


            string str10 = "C# is \"popular\" language";
            string str11 = @"C# is ""popular"" language";
        }
    }
}
