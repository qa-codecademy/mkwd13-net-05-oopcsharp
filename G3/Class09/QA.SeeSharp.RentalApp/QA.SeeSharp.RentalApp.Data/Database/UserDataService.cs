using QA.SeeSharp.RentalApp.Data.Models;

namespace QA.SeeSharp.RentalApp.Data.Database
{
    public class UserDataService : InMemoryDatabase
    {
        public User GetUserByCardNumber(int cardNumber)
        {
            return Users.FirstOrDefault(user => user.CardNumber == cardNumber);
        }
    }
}
