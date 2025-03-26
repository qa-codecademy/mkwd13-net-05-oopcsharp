namespace Qinshift.Exercise_1.Models
{
    public class Cinema
    {
        public Cinema()
        {
            Halls = new List<int>();
            Movies = new List<Movie>();
        }

        public Cinema(string name)
        {
            Name = name;
            Halls = new List<int>();
            Movies = new List<Movie>();
        }


        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching movie {movie.Title}");
        }
    }
}
