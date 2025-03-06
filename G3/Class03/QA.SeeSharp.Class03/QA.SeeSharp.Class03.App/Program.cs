namespace QA.SeeSharp.Class03.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LOOPS
            //for (counter; expression; increment/decrement)
            //{
            // CODE GOES HERE
            //}

            //for (int i = 0; i <= 100; i += 1)
            //{
            //    Console.WriteLine(i);
            //}

            // INFINITE LOOP 
            //for (; ; )
            //{

            //}

            // while with counter

            //int counter = 0;
            //while(counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter += 1;
            //}

            //int a = 100;

            //while(a != 99)
            //{
            //    if(a == 100)
            //    {
            //        a = 99;
            //    }
            //}

            // INFINITE LOOP
            //while(true)
            //{

            //}

            //bool isActive = true;
            //while(isActive)
            //{

            //    string input = Console.ReadLine();
            //    if (input == "y")
            //    {
            //        isActive = !isActive;
            //    }
            //}

            //do
            //{

            //} while (expression);

            //int counter = 0;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter += 1;
            //} while (counter < 10);

            // BREAK CONTINUE

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i == 70)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("===========================================");
            //int index = 0;
            //while(index < 100)
            //{
            //    if(index % 2 == 0)
            //    {
            //        index += 1;
            //        continue;
            //    }
            //    Console.WriteLine(index);
            //    index += 1;
            //}

            #endregion


            int[] numbersArr = new int[5];
            numbersArr[0] = 1;
            numbersArr[3] = 5;
            //numbersArr[2] = "5"; // not valid
            // numbersArr[7] = 15; // throws error

            Console.WriteLine(numbersArr);

            string[] names = new string[] { "bob", "jill", "kenny" };
            Console.WriteLine(names[2]);
            bool[] fullBoolArray = new bool[] { true, false, true, false };

            int[] shorterWay = { 1, 2, 3, 4, 5, 6, 7 };
            //string[] shortWay = new string[10];

            Console.WriteLine(names.Length);
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = Array.IndexOf(numbers, 7);
            Console.WriteLine(numbers[index]);
            Array.Reverse(numbers);
            Console.WriteLine("INDEX in reverse array: " + numbers[index]);
            int index1 = Array.IndexOf(names, "kenny");

            Array.Resize(ref numbers, 20);

            Console.WriteLine(numbers.Length);

            Console.WriteLine("==================================== FOREACH");

            string[] cars = { "ford", "opel", "tesla", "nisan", "WW", "mazda", "kia" };

            for(int i = 0; i < cars.Length; i++)
            {
                string car = cars[i];
                Console.WriteLine(car);
            }

            foreach(string car in cars)
            {
                //foreach(string car1 in cars)
                //{

                //}
                Console.WriteLine("**" + car + "**");
            }

            foreach (string car in cars)
            {
                if(car == "tesla")
                {
                    continue;
                }
                if(car == "mazda")
                {
                    break;
                }
                Console.WriteLine("==" + car + "==");

            }


            Console.WriteLine("===================================");
            // EXERCISE 04

            int[][] matrix = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 }
            };

            // EXERCISE 05

            int[] nums = new int[5];

            for(int i = 0; i < nums.Length;i += 1)
            {
                string input = Console.ReadLine();
                int number = int.Parse(input);

                nums[i] = number;
            }

            int sum = 0; // default

            foreach(int number in nums)
            {
                sum += number;
            }

            Console.WriteLine("The sum is: " + sum);

            Console.WriteLine("Hello, World!");
        }
    }
}
