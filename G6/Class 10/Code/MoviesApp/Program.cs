
using MoviesApp.Domain.Enums;
using MoviesApp.Domain.Models;

Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
Movie movie3 = new Movie("Saw", Genre.Horror, 4);
Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
Movie movie5 = new Movie("Rambo", Genre.Action, 4);
Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);
List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);
List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };


Cinema cinema1 = new Cinema("Cineplex");
cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
cinema1.Movies = MovieSet1;
Cinema cinema2 = new Cinema("Milenium");
cinema2.Halls = new List<int>() { 1, 2 };
cinema2.Movies = MovieSet2;

try
{
    int cinemaOption = GetCinemaOption();
    Cinema cinema = cinemaOption == 1 ? cinema1 : cinema2;

    Console.WriteLine("What do you want to search for: 1) All movies 2)By genre");
    string input = Console.ReadLine();
    int movieOption = int.Parse(input);  //Potenial FormatException

    if(movieOption == 1)
    {
        PlayMovie(cinema, cinema.Movies); //we send all the movies

    }else if(movieOption == 2)
    {
        //1. we need to show all genres, so the user can choose
        Console.WriteLine("Choose a genre:");
        Console.WriteLine("1) Comedy");
        Console.WriteLine("2) Action");
        Console.WriteLine("3) Horror");
        Console.WriteLine("4) Drama");
        Console.WriteLine("5) SciFi");

        string genreInput = Console.ReadLine();
        int genreOption = int.Parse(genreInput); //Potenial FormatException

        if(genreOption < 1 || genreOption > 5)
        {
            throw new Exception("Invalid genre option. Enter a number between 1 and 5");
        }

        //2. we need to filter the movies and show only movies from that genre
        //we can't compare a property that is of type Genre enum with an int value
        //so we must convert one of the values that we are comparing to the opposite type

        //either convert the enum value to the appropriate int value
        List<Movie> filteredMovies = cinema.Movies.Where(x => (int)x.Genre == genreOption).ToList();

        //or convert the int option to the appropriate Genre enum value
        //List<Movie> filteredMovies2 = cinema.Movies.Where(x => x.Genre == (Genre)genreOption).ToList();
       
        PlayMovie(cinema, filteredMovies); //here we send the movies filtered by genre
    }
    else
    {
        throw new Exception("You should enter 1 or 2 as options for the actions");
    }
}
catch(FormatException ex)
{
    Console.WriteLine("Invalid input. You should enter a number");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

int GetCinemaOption()
{
    Console.WriteLine("Please choose a cinema 1) or 2)");
    string cinemaInput = Console.ReadLine();

    int cinemaOption = int.Parse(cinemaInput); //Potenial FormatException

    if(cinemaOption != 1 && cinemaOption != 2)
    {
        throw new Exception("You must enter option 1 or 2 for the cinema");
    }
    return cinemaOption;
}

void PlayMovie(Cinema cinema, List<Movie> movies)
{
    Console.WriteLine("Enter one of the movie titles");
    foreach(Movie movie in movies)
    {
        Console.WriteLine(movie.Title);
    }

    string movieTitle = Console.ReadLine();

    //we try to check if he entered a valid movie and find that object
    Movie cinemaMovie = movies.FirstOrDefault(x => x.Title.ToLower() == movieTitle.ToLower());

    if (cinemaMovie == null)
    {
        throw new Exception("The movie you entered was not found");
    }
    cinema.MoviePlaying(cinemaMovie);
}