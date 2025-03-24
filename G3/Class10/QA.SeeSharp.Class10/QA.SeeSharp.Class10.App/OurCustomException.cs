namespace QA.SeeSharp.Class10.App
{
    public class OurCustomException : Exception
    {
        public string OurMessage { get; set; }

        public OurCustomException(string message)
        {
            OurMessage = message;
        }
    }
}
