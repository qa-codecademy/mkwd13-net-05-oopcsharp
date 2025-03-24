namespace QA.SeeSharp.Class10.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>() { new User() { Name = "Trajan" } };
            //string input = Console.ReadLine();
            //// defensive coding
            //bool isValid = int.TryParse(input, out int number);
            //if (!isValid)
            //{
            //    Console.WriteLine("Not valid input");
            //}

            //User user = users.FirstOrDefault(x => x.Name == "Slave");
            //if(user != null)
            //{
            //    user.Name = "Slave";
            //}


            //string input1 = Console.ReadLine();

            //try
            //{
            //    int num = int.Parse(input1);
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine("Null is passed as a value");
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("Format of the string cannot be parsed as a number");
            //}
            //catch(OverflowException ex)
            //{
            //    string message = string.Format("Time:{0} Message: {1} StackTrace: {2}", DateTime.Now, ex.Message, ex.StackTrace);
            //    Console.WriteLine(message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //string input = Console.ReadLine();

            //try
            //{
            //    int a = Convert.ToInt32(input);
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Error has happend");
            //}
            //finally
            //{
            //    Console.WriteLine("Im always executed");
            //}

            //try
            //{
            //    SecondThrowingOfExceprion();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}

            try
            {
                throw new OurCustomException("Our first exception");
            }
            catch(OurCustomException ex)
            {
                Console.WriteLine(ex.OurMessage);
            }

            try
            {
                SomeMethod();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }

        static void SecondThrowingOfExceprion()
        {
            try
            {
                ThrowingErrors();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        static void ThrowingErrors()
        {
            string input = Console.ReadLine();
            if (input == "a" || input == "b")
            {
                Console.WriteLine("You have entered a or b");
            }
            else
            {
                throw new Exception("That is not a ot b. Sorry");
            }
        }

        static void SomeMethod()
        {
            ThrowingErrors();
        }

        static int ToInteger(int min, int max)
        {
            var parsedNumber = 0;
            bool isValid = false;
            while (!isValid)
            {
                try
                {
                    parsedNumber = int.Parse(Console.ReadLine());
                    if (!(parsedNumber >= min && parsedNumber <= max))
                    {
                        throw new Exception($"Please selct from the given input range from {min} to {max}.");
                    }
                    isValid = !isValid;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please enter argument");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not valid input");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is to large or to low.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return parsedNumber;
        }
    }
}
