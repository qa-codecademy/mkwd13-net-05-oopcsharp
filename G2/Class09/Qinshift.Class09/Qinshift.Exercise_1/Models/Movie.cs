namespace Qinshift.Exercise_1.Models
{
    public class Movie
    {
        public Movie(string title, Genre genre, int rating, double ticketPrice)
        {
            Title = title;
            Genre = genre;

            try
            {
                if(rating > 0 && rating <= 5)
                {
                    Rating = rating;
                }
                else
                {
                    throw new Exception("Rating must have value between 1 and 5");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            TicketPrice = rating * 5;
        }




        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

    }
}
