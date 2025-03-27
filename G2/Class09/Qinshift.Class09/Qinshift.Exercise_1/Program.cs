using Qinshift.Exercise_1.Models;

Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);
List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };


Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);
List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };


Cinema cinema1 = new Cinema("Cineplex");
cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
cinema1.Movies = MovieSet1;


Cinema cinema2 = new Cinema("Milenium");
cinema2.Halls = new List<int>() { 1, 2 };
cinema2.Movies = MovieSet2;

try
{
    Console.WriteLine("Choose a cinema:");
    Console.WriteLine($"1. {cinema1.Name} \n2. {cinema2.Name}");

    int cinemaInput = int.Parse(Console.ReadLine());
    Cinema currentCinema = new Cinema();
    if(cinemaInput == 1)
    {
        currentCinema = cinema1;
    }
    else if(cinemaInput == 2) 
    {
        currentCinema = cinema2;
    }
    else
    {
        throw new Exception("You have to enter 1 or 2! You broke it!");
    }

    Console.WriteLine("Movies in the cinema:");
    Console.WriteLine("1.Show all movies \n2.Show by genre");
    int movieInput = int.Parse(Console.ReadLine());
    if (movieInput == 1)
    {
        Console.WriteLine("Choose a movie to watch: ( Write the name ) ");
        foreach (var movie in currentCinema.Movies)
        {
            Console.WriteLine(movie.Title);
        }
        string movieNameInput = Console.ReadLine();
        Movie movieToWatch = currentCinema.Movies
                                          .Where(x => x.Title.ToLower().Trim() == movieNameInput.ToLower().Trim())
                                          .FirstOrDefault();
        currentCinema.MoviePlaying(movieToWatch);
    }
    else if (movieInput == 2)
    {
        Console.WriteLine("Enter genre:");
        Console.WriteLine("1.Comedy");
        Console.WriteLine("2.Horror");
        Console.WriteLine("3.Action");
        Console.WriteLine("4.Drama");
        Console.WriteLine("5.SCIFI");
        int genreInput = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose movie to watch: ( Write the name ) ");
        foreach (var movie in currentCinema.Movies.Where(x => x.Genre == (Genre)genreInput))
        {
            Console.WriteLine(movie.Title);
        }
        string movieByGenreInput = Console.ReadLine();

        Movie movieToWatchByGenre = currentCinema.Movies
                                          .Where(x => x.Title.ToLower().Trim() == movieByGenreInput.ToLower().Trim())
                                          .FirstOrDefault();

        currentCinema.MoviePlaying(movieToWatchByGenre);
    }
    else
    {
        throw new Exception("You have entered a wrong input.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong! Try again");
}





