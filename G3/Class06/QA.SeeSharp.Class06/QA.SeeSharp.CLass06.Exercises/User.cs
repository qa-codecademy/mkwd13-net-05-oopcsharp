namespace QA.SeeSharp.CLass06.Exercises
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User()
        {
            Messages = new string[1];
        }

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = new string[] { "Hello", "Bye", "Hi" };
        }
    }
}
