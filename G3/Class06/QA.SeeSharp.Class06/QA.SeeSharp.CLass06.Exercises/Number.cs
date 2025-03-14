namespace QA.SeeSharp.CLass06.Exercises
{
    public class Number
    {
        public Number(double value)
        {
            Value = value;
            CheckIfEven();
            CheckIfInteger();
            CheckIfPositive();
        }

        public double Value { get; set; }
        public bool IsPositive { get; set; }
        public bool IsEven { get; set; }
        public bool IsInteger { get; set; }

        public void PrintNumberStats()
        {
            string even = IsEven ? "Even" : "Odd";
            string positive = IsPositive ? "Positive" : "Negative";
            string integer = IsInteger ? "Integer" : "Decimal";
            string final = string.Format(
                "The number {0} is {1} and is {2} {3} number", 
                Value, positive, even, integer);
            Console.WriteLine(final);
        }

        private bool CheckIfPositive()
        {
            IsPositive = Value > 0;
            return Value > 0;
        }

        private bool CheckIfEven()
        {
            IsEven = Value % 2 == 0;
            return IsEven;
        }

        private bool CheckIfInteger()
        {
            IsInteger = !(Value % 1 > 0);
            return IsInteger;
        }
    }
}
