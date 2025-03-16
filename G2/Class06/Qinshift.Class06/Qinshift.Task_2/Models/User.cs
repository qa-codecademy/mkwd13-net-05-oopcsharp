
namespace Qinshift.Task_2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> Messages { get; set; }
    }

}
