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

            // ESCAPE ""
            string str10 = "C# is \"popular\" language";
            string str11 = @"C# is ""popular"" language";


            // STRING FORMATING
            string yStringCuurency = string.Format("{0:C}", 125.45);
            Console.WriteLine(yStringCuurency);
            string myStringNumber = string.Format("{0:N}", 190);
            Console.WriteLine(myStringNumber);
            string myStringPercent = string.Format("{0:P}", .22);
            Console.WriteLine(myStringPercent);
            string myCustomStr = string.Format("{0:0##-###-###}", 078270396);
            Console.WriteLine(myCustomStr);

            string headers = string.Format("| {0,10} | {1, 10} |", "Id", "Order");
            string row = string.Format("| {0,10} | {1, 10} |", 25, "a box");
            Console.WriteLine(headers);
            Console.WriteLine(row);

            // STRING METHODS
            string ourString = "   We are learning C# and it is FUN and EASY. Okay maybe just FUN.    ";

            string[] splited = ourString.Split('.');
            foreach(string b in splited)
            {
                Console.WriteLine(b);
            }
            string[] splited1 = ourString.Split('.', StringSplitOptions.TrimEntries);
            foreach (string b in splited1)
            {
                Console.WriteLine(b);
                Console.WriteLine("----");
            }

            int indexOfFUN = ourString.IndexOf("FUN");
            Console.WriteLine(indexOfFUN);
            int indexOfNone = ourString.IndexOf("None");
            Console.WriteLine(indexOfNone);

            string subString = ourString.Substring(3, 18);
            Console.WriteLine(subString);

            char[] chars = ourString.ToCharArray();
            foreach (char item in chars)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(chars.ToString());

            string joinedString = string.Join(",", chars);
            Console.WriteLine(joinedString);
            string ourString2 = string.Join("*", splited);
            Console.WriteLine(ourString2);

            Console.WriteLine(new string(chars));

            string abc = " ";

            //if(abc == string.Empty || abc.Trim() == "" || abc != null)
            // CHECKS IF STRING IS NULL OR EMPTY
            bool isValidString = string.IsNullOrEmpty(abc);
            // CHECKS IF STRING IS NULL OR EMPTY OR WHITE SPACE
            bool isValidString2 = string.IsNullOrWhiteSpace(abc);
            Console.WriteLine(isValidString);
            Console.WriteLine(isValidString2);


            // DATES

            DateTime aData = new DateTime();
            Console.WriteLine(aData);
            // Creating a custom date         year month day
            DateTime customDate = new DateTime(1992, 10, 15);
            Console.WriteLine(customDate);

            // Variations:
            //string stringDate = "12.15.2012";
            //string stringDate = "12/15/2012";
            //string stringDate = "12/15/12";
            //string stringDate = "dec.15.12";
            string stringDate = "12-15-2012";

            DateTime convertDate = DateTime.Parse(stringDate);
            Console.WriteLine(convertDate);

            DateTime currentDay = DateTime.Today;
            Console.WriteLine(currentDay);

            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);

            Console.WriteLine(convertDate.Month);
            Console.WriteLine(convertDate.Day);
            Console.WriteLine(convertDate.Year);

            DateTime bDate = DateTime.Now;
            DateTime addDays = bDate.AddDays(2);
            Console.WriteLine(addDays);
            DateTime addMinusDays = bDate.AddDays(-7);
            Console.WriteLine(addMinusDays);
            bDate.AddYears(2);
            bDate.AddYears(-1);
            bDate.AddMonths(10);

            string dateFormat1 = currentDateAndTime.ToString("MM/dd/yyyy");
            string dateFormat2 = currentDateAndTime.ToString("dddd, dd MMMM yyyy");
            string dateFormat3 = string.Format("Today is {0:MM/dd/yy}, {0:dddd}", currentDateAndTime);
            string dateFormat4 = string.Format("Today is {0:dd-MMMM-yyyy}, {0:t}, {0:HH:mm}", currentDateAndTime);
            Console.WriteLine(dateFormat1);
            Console.WriteLine(dateFormat2);
            Console.WriteLine(dateFormat3);
            Console.WriteLine(dateFormat4);
        }
    }
}
