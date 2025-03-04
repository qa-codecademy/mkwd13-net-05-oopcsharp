namespace QA.SeeSharp.Class03.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            for(int i = 0; i < 100; i++)
            {
                if (i == 70)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("===========================================");
            int index = 0;
            while(index < 100)
            {
                if(index % 2 == 0)
                {
                    index += 1;
                    continue;
                }
                Console.WriteLine(index);
                index += 1;
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
