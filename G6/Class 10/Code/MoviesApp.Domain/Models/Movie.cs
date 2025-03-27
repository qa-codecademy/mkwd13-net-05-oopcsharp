//Make a class Movie. Movie must have: Title, Genre, Rating, TicketPrice and a constructor for setting them.
//Rating should be a number from 1 to 5. Throw exception if its more or less ( you should also handle other exceptions)
//Set the TicketPrice to be 5 * Rating when creating a new object

using MoviesApp.Domain.Enums;

namespace MoviesApp.Domain.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            if(string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("Title must have a value");
            }
            Title = title;
            Genre = genre;

            if(rating < 1 || rating > 5)
            {
                throw new InvalidDataException("Rating should have  a value between 1 and 5!");
            }

            Rating = rating;
            TicketPrice = 5 * rating;
        }
    }
}
