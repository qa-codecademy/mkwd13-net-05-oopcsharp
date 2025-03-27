//Make a class Cinema. Cinema must have: Name, Halls, ListOfMovies
//Cinema should have method MoviePlaying  that will have a parameter ‘movie’
//and then print out in the console “Watching Movie.Title”


namespace MoviesApp.Domain.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name is a required field for cinemas");
            }
            Name = name;
            Halls = new List<int>();
            Movies = new List<Movie>();
        }

        public void MoviePlaying(Movie movie)
        {
            if(movie == null)
            {
                throw new ArgumentNullException("We must have a value for the movie that is playing");
            }

            //check if the movie is a part of the Movies list (if the movie is playing in this cinema)
            Movie foundMovie = Movies.FirstOrDefault(m => m.Title.ToLower() == movie.Title.ToLower());
            if(foundMovie == null)
            {
                throw new Exception($"The movie {movie.Title} is not playing in this cinema");
            }

            Console.WriteLine($"We are watching {movie.Title}");
        }
    }
}
