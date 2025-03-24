namespace QA.SeeSharp.RentalApp.Data.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        // Card number will be used as Username
        public int CardNumber { get; set; }
        public bool IsSubscriptionExpired{ get; set; }
        public DateTime SubscriptionExpireTime { get; set; }

        public List<RentalInfo> RentedMovies { get; set; }
        public List<RentalInfo> RentedMoviesHistory { get; set; }

        public User()
        {
            IsSubscriptionExpired = false;
            RentedMovies = new List<RentalInfo>();
            RentedMoviesHistory = new List<RentalInfo>();
        }
    }
}
