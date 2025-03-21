using QA.SeeSharp.RentalApp.Data.Models;

namespace QA.SeeSharp.RentalApp.Data.Database
{
    public class UserDataService : InMemoryDatabase
    {
        public User GetUserByCardNumber(int cardNumber)
        {
            return Users.FirstOrDefault(user => user.CardNumber == cardNumber);
        }

        public List<int> GetAllCardNumbers()
        {
            return Users.Select(user => user.CardNumber).ToList();
        }

        public void InsertNewUser(User user)
        {
            Users.Add(user);
        }
    }
}
